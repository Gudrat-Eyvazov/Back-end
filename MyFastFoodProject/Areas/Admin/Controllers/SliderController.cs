using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyFastFoodProject.Controllers;
using MyFastFoodProject.DAL;
using MyFastFoodProject.Extensions;
using MyFastFoodProject.Models;

namespace MyFastFoodProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SliderController : Controller
    {
        private AppDbContext appDbContext;
        private readonly IWebHostEnvironment _env;
        public SliderController(AppDbContext _appDbContext, IWebHostEnvironment env)
        {

            appDbContext = _appDbContext;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(appDbContext.Sliders.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {

            if (!FormFileExtensions.IsImage(slider.ImgFile))
            {
                ModelState.AddModelError("Photo", "Image type is not valid");
                return View(slider);
            }
            if (FormFileExtensions.IsImage(slider.ImgFile))
            {
                string filename = await slider.ImgFile.SaveFileAsync(_env.WebRootPath, "uploadSlider");
                slider.ImgUrl = filename;

                appDbContext.Sliders.Add(slider);
                appDbContext.SaveChanges();
            }
            else
            {
                return RedirectToAction("Create");
            }

            return RedirectToAction("Index");
        }
        public JsonResult Delete(int id)
        {
            if (id == 0)
            {
                return Json(new
                {
                    status = 400
                });
            }
            var slider = appDbContext.Sliders.Find(id);
            if (slider != null)
            {
                appDbContext.Sliders.Remove(slider);
                appDbContext.SaveChanges();
            }
            return Json(new
            {
                status = 200
            });

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var model = appDbContext.Sliders.FirstOrDefault(x => x.Id == id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Slider slider)
        {
            var oldSlider = appDbContext.Sliders.Find(slider.Id);
            //if (!ModelState.IsValid)
            //{
            //    return View(slider);
            //}
            if (slider.ImgFile != null)
            {

                if (!slider.ImgFile.IsImage())
                {
                    ModelState.AddModelError("Photo", "Image type is not valid");
                    return View(slider);
                }
                string filename = await slider.ImgFile.SaveFileAsync(_env.WebRootPath, "uploadSlider");

                oldSlider.ImgUrl = filename;
            }
            oldSlider.Tittle = slider.Tittle;
            oldSlider.Subtitle = slider.Subtitle;
            oldSlider.Description = slider.Description;
            oldSlider.LastPrice = slider.LastPrice;
            oldSlider.NewPrice = slider.NewPrice;
            oldSlider.IsCheck = slider.IsCheck;
           
            appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
