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
            List<Blum> listaDeAfisat = _context.Blums.Where(b => !b.IsDatAfara).ToList();
            return View(listaDeAfisat);
        }

        public IActionResult ImportFile()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ImportFile(List<IFormFile> files)
        {
            IFormFile formFile = files[0];
            if (formFile == null || formFile.Length <= 0)
            {
                ViewBag.Mesaj = "Fisierul nu s-a incarcat";
                return View();
            }
            if (!formFile.FileName.EndsWith(".xlsx"))
            {
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
