using Microsoft.AspNetCore.Http;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ItroducereDateCuptor
{
    public static class Auxiliar
    {
        // Task returnare lista blumuri din fisier excel 
        public static async Task<List<Blum>> GetBlumsListFromFileAsync(IFormFile formFile)
        {
            var list = new List<Blum>();

            using (var stream = new MemoryStream())
            {
                await formFile.CopyToAsync(stream);

                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    var rowCount = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rowCount; row++)
                    {
                        int id = int.TryParse(worksheet.Cells[row, 1].Value.ToString().Trim(), out int i) ? i : 0;
                        int diam = int.TryParse(worksheet.Cells[row, 2].Value.ToString().Trim(), out int d) ? d : 0;
                        list.Add(new Blum
                        {
                            //Id = id, *Deoarece introduc in SQL server las sa fie adaugat de sql, pentru a fi sigur ca sunt diferite*
                            Diametru = diam,
                            Sarja = worksheet.Cells[row, 3].Value.ToString().Trim(),
                            Furnizor = worksheet.Cells[row, 4].Value.ToString().Trim(),
                            Calitate = worksheet.Cells[row, 5].Value.ToString().Trim()
                        });
                    }
                }
            }
            return list;
        }

        // Variabila globala  Counter bare date afara
        public static int CounterBareDateAfara { get; set; }

        // Scriere In PLC 
        /*
                     string proba = "false";
            string probaText = "necitit";
            Plc RasturnatorFataCaja3 = new Plc(CpuType.S7300, "172.16.4.60", 0, 2);
            var cancelTask = new CancellationTokenSource();
            var performTaskCheckAvailability = Task.Run(() =>
            {
                //if (RasturnatorFataCaja3.IsAvailable)
                RasturnatorFataCaja3.Open();

                proba = Convert.ToBoolean(RasturnatorFataCaja3.Read("E0.0")).ToString();
                probaText = Convert.ToString(RasturnatorFataCaja3.Read(DataType.DataBlock, 1, 12, VarType.String, 10));

                if (RasturnatorFataCaja3.IsConnected) RasturnatorFataCaja3.Close();
            }, cancelTask.Token);
            if (!performTaskCheckAvailability.Wait(TimeSpan.FromSeconds(1)))
                cancelTask.Cancel(); ; // Asteapta Task sa fie complet in 1 sec 
            ViewBag.Citire = proba;
            ViewBag.Text = probaText;
            return View();
            //return View(proba);
         */

    }
}
