using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ItroducereDateCuptor;
using System.IO;
using OfficeOpenXml;

namespace ItroducereDateCuptor.Controllers
{
    public class BlumsController : Controller
    {
        private readonly MyAppDbContext _context;

        public BlumsController(MyAppDbContext context)
        {
            _context = context;
        }

        // GET: Blums
        public async Task<IActionResult> Index()
        {
            return View(await _context.Blums.ToListAsync());
        }

        // POST: Blums/Delete/All
        public async Task<IActionResult> DeleteAll()
        {
            _context.Blums.RemoveRange(_context.Blums);            
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // Functie exportare data to excel file
        public async Task<IActionResult> ExportToExcelAsync()
        {
            List<Blum> listaDeAfisat = await _context.Blums.ToListAsync();

            var stream = new MemoryStream();

            using (var pck = new ExcelPackage(stream))
            {
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Laminare");
                ws.Cells["A1:Z1"].Style.Font.Bold = true;

                ws.Cells["A1"].Value = "Id";
                ws.Cells["B1"].Value = "Diametru";
                ws.Cells["C1"].Value = "Sarja";
                ws.Cells["D1"].Value = "Furnizor";
                ws.Cells["E1"].Value = "Calitate";
                ws.Cells["F1"].Value = "Dat afara";
                ws.Cells["G1"].Value = "Retur";
                ws.Cells["H1"].Value = "Rebut";
                ws.Cells["I1"].Value = "Ora data afara";

                int rowStart = 2;
                foreach (var elem in listaDeAfisat)
                {
                    ws.Cells[string.Format("A{0}", rowStart)].Value = elem.Id;
                    ws.Cells[string.Format("B{0}", rowStart)].Value = elem.Diametru;
                    ws.Cells[string.Format("C{0}", rowStart)].Value = elem.Sarja;
                    ws.Cells[string.Format("D{0}", rowStart)].Value = elem.Furnizor;
                    ws.Cells[string.Format("E{0}", rowStart)].Value = elem.Calitate;
                    ws.Cells[string.Format("F{0}", rowStart)].Value = elem.IsDatAfara;
                    ws.Cells[string.Format("G{0}", rowStart)].Value = elem.IsRetur;
                    ws.Cells[string.Format("H{0}", rowStart)].Value = elem.IsRebut;
                    ws.Cells[string.Format("I{0}", rowStart)].Value = elem.DataOraLaminare;
                    rowStart++;
                }

                ws.Cells["A:AZ"].AutoFitColumns();

                pck.Save();
            }
            stream.Position = 0;
            string excelName = "RaportProductie.xlsx";
            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelName);

        }
        // GET: Blums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blum = await _context.Blums
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blum == null)
            {
                return NotFound();
            }

            return View(blum);
        }

        // GET: Blums/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Blums/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Diametru,Sarja,Furnizor,Calitate,IsDatAfara,IsRetur,IsRebut,DataOraLaminare")] Blum blum)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blum);
        }

        // GET: Blums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blum = await _context.Blums.FindAsync(id);
            if (blum == null)
            {
                return NotFound();
            }
            return View(blum);
        }

        // POST: Blums/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Diametru,Sarja,Furnizor,Calitate,IsDatAfara,IsRetur,IsRebut,DataOraLaminare")] Blum blum)
        {
            if (id != blum.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlumExists(blum.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(blum);
        }

        // GET: Blums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blum = await _context.Blums
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blum == null)
            {
                return NotFound();
            }

            return View(blum);
        }

        // POST: Blums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blum = await _context.Blums.FindAsync(id);
            _context.Blums.Remove(blum);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlumExists(int id)
        {
            return _context.Blums.Any(e => e.Id == id);
        }
    }
}
