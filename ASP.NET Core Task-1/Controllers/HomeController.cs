using ASP.NET_Core_Task_1.DAL;
using ASP.NET_Core_Task_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP.NET_Core_Task_1.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContex appDbContex;
        public HomeController(AppDbContex _appDbContex)
        {
            appDbContex = _appDbContex;
        }
        public IActionResult Index()
        {
            //List<Ozellik> sliders = new List<Ozellik>();
            //Ozellik ozellik = new Ozellik
            //{
            //    id = 1,
            //    subtittle = "new trend",
            //    tittle = "dma",

            //    description = " miri en acqi yiyiim",
            //    ImgUrl = "contact-img.jpg"
            //};
            //Ozellik ozellik1 = new Ozellik
            //{
            //    id = 1,
            //    subtittle = "new trend1",
            //    tittle = "dma1",

            //    description = "1 miri en acqi yiyiim",
            //    ImgUrl = "contact-img.jpg"
            //};



            //Ozellik ozellik2 = new Ozellik
            //{
            //    id = 1,
            //    subtittle = "2new trend",
            //    tittle = "2dma",

            //    description = "2 miri en acqi yiyiim",
            //    ImgUrl = "contact-img.jpg"
            //};
            //sliders.Add(ozellik);
            //sliders.Add(ozellik1);
            //sliders.Add(ozellik2);
            return View(appDbContex.Ozelliks.ToList()) ;
        }

        public IActionResult Why()
        { return View(); }
        public IActionResult Tranier()
        { return View(); }

        public IActionResult Contact() { return View(); }

    }
}
