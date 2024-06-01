using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyFastFoodProject.DAL;
using MyFastFoodProject.Models;
using MyFastFoodProject.Models.ViewModels;
using MyFastFoodProject.Services;

namespace MyFastFoodProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext appDbContext;
        private readonly UserManager<ProgramUser> _userManager;
        private readonly SignInManager<ProgramUser> _signinmanager;
        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly IEmailService _emailService;
        public AccountController(AppDbContext _appDbContext, UserManager<ProgramUser> userManager, IEmailService emailService, SignInManager<ProgramUser> signinmanager, RoleManager<IdentityRole> roleManager)
        {
            appDbContext = _appDbContext;
            _userManager = userManager;
            _signinmanager = signinmanager;
            _emailService = emailService;
            _roleManager = roleManager;
        }
        [HttpPost]
        public async Task<ActionResult> SignUp(SignUpVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            ProgramUser programUser = new ProgramUser
            {
                Email = model.TestEmail,
                UserName = model.UserName
            };

            var result = await _userManager.CreateAsync(programUser, model.Password);
            if (result.Succeeded)
            {
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(programUser);
                var confirmationLink = Url.Action("ConfirmEmail", "Account", new { userId = programUser.Id, token = token }, Request.Scheme);
                await _emailService.SendEmailAsync(model.TestEmail, "Confirm your email", $"Please confirm your account by <a href='{confirmationLink}'>clicking here</a>.");
                await _userManager.AddToRoleAsync(programUser, "User");
                return RedirectToAction("Index", "Home");
            }
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);

            }

            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Login(LoginVM model)
        {
            
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "something wrong");
            }
            var User = await _userManager.FindByNameAsync(model.UserName);
            if (User != null)
            {
                var result = await _signinmanager.PasswordSignInAsync(User, model.Password, model.IsRemember, false);
                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Password or UserName incorrect");
                }

                await _signinmanager.PasswordSignInAsync(User, model.Password, model.IsRemember, false);
            }
            return RedirectToAction("Index", "Home");

        }
        
        public async Task<IActionResult> Logout()
        {

            await _signinmanager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

       

        //public async Task SeeedAdmin()
        //{

        //    if (_userManager.FindByEmailAsync("gudrateyvazov@gmail.com").Result==null)
        //    {
        //        ProgramUser programUser = new ProgramUser()
        //        {
                    
        //            Email = "gudrateyvazov@gmail.com",
        //            UserName = "gudrat"
        //        };
        //        var result = await _userManager.CreateAsync(programUser,"Sinan123.");
        //        if (result.Succeeded)
        //        {
        //            await _userManager.AddToRoleAsync(programUser, "Admin");
        //            await _signinmanager.SignInAsync(programUser,true);
        //            RedirectToAction("Index", "Home");  

        //        }
                
               
        //    }
           
        //}
        //public async Task SeeedRoles()
        //{

        //    if (!await _roleManager.RoleExistsAsync(roleName: "Admin"))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole(roleName: "Admin"));
        //    }
        //    if (!await _roleManager.RoleExistsAsync(roleName: "User"))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole(roleName: "User"));
        //    }
        //}

    }
}
