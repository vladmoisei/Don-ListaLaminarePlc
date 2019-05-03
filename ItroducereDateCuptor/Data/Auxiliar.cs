using Microsoft.AspNetCore.Http;
using OfficeOpenXml;
using S7.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
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
        public static void ScriereInPlc (Blum blum)
        {
            using(Plc RasturnatorFataCaja3 = new Plc(CpuType.S7300, "172.16.4.60", 0, 2))
            {
                var cancelTask = new CancellationTokenSource();
                var performTaskCheckAvailability = Task.Run(() =>
                {
                    //if (RasturnatorFataCaja3.IsAvailable)
                    RasturnatorFataCaja3.Open();
                    bool isDataAfara = false;
                    string id = blum.Id.ToString();
                    string diametru = blum.Diametru.ToString();
                    string sarja = blum.Sarja;
                    string furnizor = blum.Furnizor;
                    string calitate = blum.Calitate;
                    string dataOraLaminare = blum.DataOraLaminare;
                    // Am scris decalat cu 2 byte ( inca nu stiu de ce, primii 2 bytes sunt rezervati)
                    // Write to Plc Id
                    RasturnatorFataCaja3.WriteBytes(DataType.DataBlock, 2, 4, S7.Net.Types.String.ToByteArray(id, 10));
                    // Write to Plc Diametru
                    RasturnatorFataCaja3.WriteBytes(DataType.DataBlock, 2, 16, S7.Net.Types.String.ToByteArray(diametru, 3));
                    // Write to Plc Sarja
                    RasturnatorFataCaja3.WriteBytes(DataType.DataBlock, 2, 22, S7.Net.Types.String.ToByteArray(sarja, 8));
                    // Write to Plc Furnizor
                    RasturnatorFataCaja3.WriteBytes(DataType.DataBlock, 2, 32, S7.Net.Types.String.ToByteArray(furnizor, 2));
                    // Write to Plc Calitate
                    RasturnatorFataCaja3.WriteBytes(DataType.DataBlock, 2, 36, S7.Net.Types.String.ToByteArray(calitate, 10));
                    // Write to Plc dataOraLaminare
                    RasturnatorFataCaja3.WriteBytes(DataType.DataBlock, 2, 48, S7.Net.Types.String.ToByteArray(dataOraLaminare, 16));
                    // Write true to a bit for each bar
                    RasturnatorFataCaja3.Write("DB2.DBX0.0", true);
                    //bool proba = Convert.ToBoolean(RasturnatorFataCaja3.Read("E0.0")).ToString();
                    //string probaText = Convert.ToString(RasturnatorFataCaja3.Read(DataType.DataBlock, 1, 12, VarType.String, 10));
                    // Inchidere conexiune plc
                    if (RasturnatorFataCaja3.IsConnected) RasturnatorFataCaja3.Close();
                }, cancelTask.Token);
                // Cancel task in timpul alocat
                if (!performTaskCheckAvailability.Wait(TimeSpan.FromSeconds(1)))
                    cancelTask.Cancel(); ; // Asteapta Task sa fie complet in 1 sec 
            }
        }
    }
}
