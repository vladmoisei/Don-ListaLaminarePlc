using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ItroducereDateCuptor.Models;
using Microsoft.AspNetCore.Http;

namespace ItroducereDateCuptor.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyAppDbContext _context;

        public HomeController(MyAppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Blum> listaDeAfisat = _context.Blums.Where(b => !b.IsDatAfara && !b.IsRetur).ToList();
            return View(listaDeAfisat);
        }

        [HttpPost]
        public IActionResult IntroducereInLaminare()
        {
            Blum blumModificat = _context.Blums.Where(b => !b.IsDatAfara && !b.IsRetur).FirstOrDefault();
            if (blumModificat != null)
            {
                blumModificat.IsDatAfara = true;
                blumModificat.DataOraLaminare = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                _context.SaveChanges();
                //return Content(blumModificat.Id.ToString() + blumModificat.IsDatAfara.ToString());
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ReturBlum()
        {
            Blum blumModificat = _context.Blums.Where(b => !b.IsDatAfara && !b.IsRetur).FirstOrDefault();
            if (blumModificat != null)
            {
                blumModificat.IsRetur = true;
                blumModificat.DataOraLaminare = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                _context.SaveChanges();
                //return Content(blumModificat.Id.ToString() + blumModificat.IsDatAfara.ToString());
            }
            return RedirectToAction("Index");
        }

        public IActionResult IntroducereRetur()
        {

            return View("Index");
        }

        public IActionResult ImportFile()
        {
            ViewBag.Hidden = "hidden";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ImportFile(List<IFormFile> files)
        {
            if (files.Count == 0)
            {
                ViewBag.Hidden = "";
                ViewBag.Mesaj = "Fisierul nu s-a incarcat";
                return View();
               }

            IFormFile formFile = files[0];
            if (!formFile.FileName.EndsWith(".xlsx"))
            {
                ViewBag.Hidden = "";
                ViewBag.Mesaj = "Fisierul nu are extensia .xlsx!";
                return View();
            }


            List<Blum> listaBlumuri = await Auxiliar.GetBlumsListFromFileAsync(formFile);

            if (listaBlumuri != null)
            {
                foreach (Blum item in listaBlumuri)
                {                 
                    _context.Add(item);
                }
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
            //return Json(Blums.ListOfBlums);
            //return RedirectToAction("Index", "Home", listaBlumuri);
            //return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
