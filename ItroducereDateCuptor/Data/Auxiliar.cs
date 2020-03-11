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
        // Introducere in fisier blum cu blum
        public static async Task<List<Blum>> GetBlumsListFromFileAsync(IFormFile formFile)
        //public static List<Blum> GetBlumsListFromFileAsync(IFormFile formFile)
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
                        int lung = int.TryParse(worksheet.Cells[row, 7].Value.ToString().Trim(), out int e) ? e : 0;
                        list.Add(new Blum
                        {
                            // Id = id, *Deoarece introduc in SQL server las sa fie adaugat de sql, pentru a fi sigur ca sunt diferite*
                            Diametru = diam,
                            Sarja = worksheet.Cells[row, 3].Value.ToString().Trim(),
                            Furnizor = worksheet.Cells[row, 4].Value.ToString().Trim(),
                            Calitate = worksheet.Cells[row, 5].Value.ToString().Trim(),
                            Sectiune = worksheet.Cells[row, 6].Value.ToString().Trim(),
                            // Sectiune = Auxiliar.GetSectiuneByFurnizor(worksheet.Cells[row, 4].Value.ToString().Trim()),
                            Lungime = lung,
                            Normalizare = worksheet.Cells[row, 8].Value.ToString().Trim()
                        });
                    }
                }
            }

            return list;
        }

        // Task returnare lista blumuri din fisier excel 
        // Introducere in fisier sarja de blumuri, si extrag de acolo blum cu blum
        public static async Task<List<Blum>> GetBlumsListFromExcelFileBySarjaAsync(IFormFile formFile)
        //public static List<Blum> GetBlumsListFromFileAsync(IFormFile formFile)
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
                        //Id = id, *Deoarece introduc in SQL server las sa fie adaugat de sql, pentru a fi sigur ca sunt diferite*
                        //int id = int.TryParse(worksheet.Cells[row, 1].Value.ToString().Trim(), out int c) ? c : 0;
                        int diam = int.TryParse(worksheet.Cells[row, 2].Value.ToString().Trim(), out int d) ? d : 0;                        
                        string sarja = worksheet.Cells[row, 3].Value.ToString().Trim();
                        string furnizor = worksheet.Cells[row, 4].Value.ToString().Trim();
                        string calitate = worksheet.Cells[row, 5].Value.ToString().Trim();
                        // Sectiune este in functie de furnizor, predefinit: Auxiliar.GetSectiuneByFurnizor(worksheet.Cells[row, 4].Value.ToString().Trim());
                        string sectiune = worksheet.Cells[row, 6].Value.ToString().Trim();
                        int lung = int.TryParse(worksheet.Cells[row, 7].Value.ToString().Trim(), out int e) ? e : 0;
                        string normalizare = worksheet.Cells[row, 8].Value.ToString().Trim();
                        int nrBucati = int.TryParse(worksheet.Cells[row, 9].Value.ToString().Trim(), out int f) ? f : 0;
                        for (int i = 0; i < nrBucati; i++)
                        {
                            list.Add(new Blum
                            {
                                //Id = id++,
                                Diametru = diam,
                                Sarja = sarja,
                                Furnizor = furnizor,
                                Calitate = calitate,
                                Sectiune = sectiune,
                                Lungime = lung,
                                Normalizare = normalizare
                            });
                        }                        
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
                    int id = blum.Id;
                    short diametru = (short)blum.Diametru;
                    string sarja = blum.Sarja;
                    string furnizor = blum.Furnizor;
                    string calitate = blum.Calitate;
                    string dataOraLaminare = blum.DataOraLaminare;

                    // Write true to a bit for each bar
                    RasturnatorFataCaja3.Write("DB2.DBX0.0", true);
                    // Am scris decalat cu 2 byte ( inca nu stiu de ce, primii 2 bytes sunt rezervati)
                    // Write to Plc Id
                    RasturnatorFataCaja3.Write("DB2.DBD2", id);
                    //RasturnatorFataCaja3.WriteBytes(DataType.DataBlock, 2, 4, S7.Net.Types.String.ToByteArray(id, 10));
                    // Write to Plc Diametru
                    RasturnatorFataCaja3.Write("DB2.DBW6", diametru);
                    //RasturnatorFataCaja3.WriteBytes(DataType.DataBlock, 2, 16, S7.Net.Types.String.ToByteArray(diametru, 3));
                    // Write to Plc Sarja
                    RasturnatorFataCaja3.WriteBytes(DataType.DataBlock, 2, 10, S7.Net.Types.String.ToByteArray(sarja, 8));
                    // Write to Plc Furnizor
                    RasturnatorFataCaja3.WriteBytes(DataType.DataBlock, 2, 20, S7.Net.Types.String.ToByteArray(furnizor, 2));
                    // Write to Plc Calitate
                    RasturnatorFataCaja3.WriteBytes(DataType.DataBlock, 2, 24, S7.Net.Types.String.ToByteArray(calitate, 10));
                    // Write to Plc dataOraLaminare
                    RasturnatorFataCaja3.WriteBytes(DataType.DataBlock, 2, 36, S7.Net.Types.String.ToByteArray(dataOraLaminare, 16));
                    
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

        // Functie Get Sectiune in functie de furnizor (dat de Bogdan)
        public static string GetSectiuneByFurnizor(string furnizor)
        {
            switch (furnizor)
            {
                case "TK":
                    return "360x360";
                case "VA":
                    return "390x283";
                case "SW":
                    return "430x320";
                case "SH":
                    return "320x270";
                case "PS":
                    return "400x300";
                case "SO":
                    return "250x300";

                default:
                    break;
            }
            return "";
        }
    }
}
