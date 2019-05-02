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
            // Selectie lista blumuri care nu sunt date afara sau retur
            List<Blum> listaDeAfisat = _context.Blums.Where(b => !b.IsDatAfara && !b.IsRetur).ToList();
            // Adaugare in lista pe prima pozitie ultima bucata data afara sau retur
            listaDeAfisat.Insert(0, _context.Blums.Where(b => b.IsDatAfara || b.IsRetur).ToList().LastOrDefault());
            //string listaDeAfisatt = "proba";
            // Creare parametru nr bare date afara pentru a il transfera la functie SignalR
            int nrBareDateAfara = ViewBag.CounterBareDateAfara;
            // Creare parametru JSON din lista afisare pentru a trimite in SignalR
            string listaDeTrimisInJavaScript = JsonConvert.SerializeObject(listaDeAfisat, Formatting.None);
            // SignalR - trimit la toti clientii lista actualizata si nrBareDateAfara
            await _hub.Clients.All.SendAsync("show_data", listaDeTrimisInJavaScript, nrBareDateAfara);
            return View(listaDeAfisat);
        }

        // Actiune resetare counter bare pe schimb
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

        // Actiune introducere Blum in Laminare cand apasa butonul
        [HttpPost]
        public IActionResult IntroducereInLaminare()
        {
            // Selectam din lista sql primul blum care nu e dat afara sau retur
            Blum blumModificat = _context.Blums.Where(b => !b.IsDatAfara && !b.IsRetur).FirstOrDefault();
            if (blumModificat != null)
            {
                // Ii atribuim proprietate IsDataAfara = true plus data si ora
                blumModificat.IsDatAfara = true;
                blumModificat.DataOraLaminare = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                //Salvam modificari in sql
                _context.SaveChanges();
                // Incrementam counter bare data afara
                Auxiliar.CounterBareDateAfara++;
            }
            return RedirectToAction("Index");
        }

        // La fel ca la introducere in laminare (doar ca e pt retur)
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

        // Actiune import data from excel file
        [HttpPost]
        public async Task<IActionResult> ImportFile(List<IFormFile> files)
        {
            // Verificam daca lista de fisiera incarcata  are 0 elemente si returnam msj
            if (files.Count == 0)
            {
                ViewBag.Hidden = "";
                ViewBag.Mesaj = "Fisierul nu s-a incarcat";
                return View();
               }

            // Cream fisier din primul lelement din lista de fisiere
            IFormFile formFile = files[0];
            // Verificam daca fisierul are extensia .xlsx
            if (!formFile.FileName.EndsWith(".xlsx"))
            {
                ViewBag.Hidden = "";
                ViewBag.Mesaj = "Fisierul nu are extensia .xlsx!";
                return View();
            }

            //Cream lista de blumuri din fisier excel
            List<Blum> listaBlumuri = await Auxiliar.GetBlumsListFromFileAsync(formFile);

            // Actualizam baza de date cu lista de blumuri din fisier
            if (listaBlumuri != null)
            {
                foreach (Blum item in listaBlumuri)
                {                 
                    _context.Add(item);
                }
                _context.SaveChanges();
            }

            // Redirection la Index
            return RedirectToAction("Index", "Home");
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
