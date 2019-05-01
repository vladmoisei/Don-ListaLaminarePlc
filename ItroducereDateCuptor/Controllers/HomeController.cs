using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ItroducereDateCuptor.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using IntroducereDateCuptor;
using Newtonsoft.Json;

namespace ItroducereDateCuptor.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyAppDbContext _context;
        private readonly IHubContext<ListaHub> _hub;

        public HomeController(MyAppDbContext context, IHubContext<ListaHub> hub)
        {
            _context = context;
            _hub = hub;
        }
        
            //IActionResult
        public async Task<IActionResult> Index()
        {
            // Returnare counter bare data afara (verific, daca nu exista il initializez cu 0)
            Auxiliar.CounterBareDateAfara = string.IsNullOrEmpty(Auxiliar.CounterBareDateAfara.ToString()) ? 0 : Auxiliar.CounterBareDateAfara;
            ViewBag.CounterBareDateAfara = Auxiliar.CounterBareDateAfara;

            List<Blum> listaDeAfisat = _context.Blums.Where(b => !b.IsDatAfara && !b.IsRetur).ToList();
            listaDeAfisat.Insert(0, _context.Blums.Where(b => b.IsDatAfara || b.IsRetur).ToList().LastOrDefault());
            //string listaDeAfisatt = "proba";
            int nrBareDateAfara = ViewBag.CounterBareDateAfara;
            string listaDeTrimisInJavaScript = JsonConvert.SerializeObject(listaDeAfisat, Formatting.None);
            await _hub.Clients.All.SendAsync("show_data", listaDeTrimisInJavaScript, nrBareDateAfara);
            return View(listaDeAfisat);
        }

        // Actioune resetare counter bare pe schimb
        public IActionResult ResetCountBar()
        {
            Auxiliar.CounterBareDateAfara = 0;
            return RedirectToAction("Index");
        }

        // Neutilizata
        // Functie verificare daca se incadreaza in timpul de productie pe unul din schimburi
        public bool IsInShiftsTime()
        {
            DateTime t1 = DateTime.Now;
            DateTime timeStartShift1 = Convert.ToDateTime("08:00:00 AM");
            DateTime timeStopShift1 = Convert.ToDateTime("06:00:00 PM");
            DateTime timeStartShift2 = Convert.ToDateTime("08:00:00 PM");
            DateTime timeStopShift2 = Convert.ToDateTime("06:00:00 AM");

            if (DateTime.Compare(t1, timeStartShift1) > 0 && (DateTime.Compare(t1, timeStopShift1) < 0))
                return true;

            if (DateTime.Compare(t1, timeStartShift2) > 0 && (DateTime.Compare(t1, timeStopShift2) < 0))
                return true;

            return false;
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
                Auxiliar.CounterBareDateAfara++;
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
                Auxiliar.CounterBareDateAfara++;
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
