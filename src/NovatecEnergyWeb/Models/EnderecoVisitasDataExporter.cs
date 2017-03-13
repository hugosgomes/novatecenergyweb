using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using NovatecEnergyWeb.Models.StoredProcedures;
using System.IO;
using OfficeOpenXml;
namespace NovatecEnergyWeb.Models
{
    public class EnderecoVisitasDataExporter
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public string FileName { get; set; }
        private string WebRootFolder;

        public EnderecoVisitasDataExporter(IHostingEnvironment he)
        {
            _hostingEnvironment = he;
            WebRootFolder = _hostingEnvironment.WebRootPath + "\\excel";
        }

        public byte[] ExportaPadraoNovatec(List<_11_LoteAtivo> data)
        {
            FileName = @"" + DateTime.Now.ToString("yyMMddHHmmss") + "_Visitas.xlsx";
            File.Copy(Path.Combine(WebRootFolder, @"formatoNovatec.xlsx"), Path.Combine(WebRootFolder, FileName));

            FileInfo file = new FileInfo(Path.Combine(WebRootFolder, FileName));

            using (ExcelPackage package = new ExcelPackage(file))
            {
                // ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("qExcel");
                ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();

                for (int i = 0; i < data.Count(); i++)
                {
                    worksheet.Cells["A" + (i + 2).ToString()].Value = data[i].Casa;
                    worksheet.Cells["A" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["B" + (i + 2).ToString()].Value = data[i].Lote;
                    worksheet.Cells["B" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["C" + (i + 2).ToString()].Value = data[i].Z;
                    worksheet.Cells["C" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["D" + (i + 2).ToString()].Value = data[i].D;
                    worksheet.Cells["D" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["E" + (i + 2).ToString()].Value = data[i].Ar;
                    worksheet.Cells["E" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["F" + (i + 2).ToString()].Value = data[i].Condominio;
                    worksheet.Cells["F" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["G" + (i + 2).ToString()].Value = data[i].Complemento;
                    worksheet.Cells["G" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["H" + (i + 2).ToString()].Value = data[i].Num;
                    worksheet.Cells["H" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["I" + (i + 2).ToString()].Value = data[i].Bloco;
                    worksheet.Cells["I" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["J" + (i + 2).ToString()].Value = data[i].Apt;
                    worksheet.Cells["J" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["K" + (i + 2).ToString()].Value = data[i].Pt;
                    worksheet.Cells["K" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["L" + (i + 2).ToString()].Value = data[i].Localidade;
                    worksheet.Cells["L" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["M" + (i + 2).ToString()].Value = data[i].Bairro;
                    worksheet.Cells["M" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["N" + (i + 2).ToString()].Value = data[i].Via;
                    worksheet.Cells["N" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["O" + (i + 2).ToString()].Value = data[i].Logradouro;
                    worksheet.Cells["O" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["P" + (i + 2).ToString()].Value = data[i].CasaStatus;
                    worksheet.Cells["P" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["Q" + (i + 2).ToString()].Value = data[i].Visitado;
                    worksheet.Cells["Q" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["R" + (i + 2).ToString()].Value = data[i].Visitas;
                    worksheet.Cells["R" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["S" + (i + 2).ToString()].Value = data[i].Ausentes;
                    worksheet.Cells["S" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["T" + (i + 2).ToString()].Value = data[i].VendaApp;
                    worksheet.Cells["T" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["U" + (i + 2).ToString()].Value = data[i].UltMotivo;
                    worksheet.Cells["U" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["V" + (i + 2).ToString()].Value = data[i].Dtult;
                    worksheet.Cells["V" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["W" + (i + 2).ToString()].Value = data[i].Agult;
                    worksheet.Cells["W" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["X" + (i + 2).ToString()].Value = data[i].StatusCl;
                    worksheet.Cells["X" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["Y" + (i + 2).ToString()].Value = data[i].DtStatusCl;
                    worksheet.Cells["Y" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["Z" + (i + 2).ToString()].Value = data[i].CasoA;
                    worksheet.Cells["Z" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AA" + (i + 2).ToString()].Value = data[i].CasoB;
                    worksheet.Cells["AA" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AB" + (i + 2).ToString()].Value = data[i].CasoC;
                    worksheet.Cells["AB" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AC" + (i + 2).ToString()].Value = data[i].CasoD;
                    worksheet.Cells["AC" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AD" + (i + 2).ToString()].Value = data[i].Zid;
                    worksheet.Cells["AD" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AE" + (i + 2).ToString()].Value = data[i].Did;
                    worksheet.Cells["AE" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AF" + (i + 2).ToString()].Value = data[i].Aid;
                    worksheet.Cells["AF" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AG" + (i + 2).ToString()].Value = data[i].CondId;
                    worksheet.Cells["AG" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AH" + (i + 2).ToString()].Value = data[i].PtId;
                    worksheet.Cells["AH" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AI" + (i + 2).ToString()].Value = data[i].IdLote;
                    worksheet.Cells["AI" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AJ" + (i + 2).ToString()].Value = data[i].IdultMotivo;
                    worksheet.Cells["AJ" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AK" + (i + 2).ToString()].Value = data[i].IdAgult;
                    worksheet.Cells["AK" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AL" + (i + 2).ToString()].Value = data[i].StatusClid;
                    worksheet.Cells["AL" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AM" + (i + 2).ToString()].Value = data[i].ClId;
                    worksheet.Cells["AM" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AN" + (i + 2).ToString()].Value = data[i].Dtult2;
                    worksheet.Cells["AN" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AO" + (i + 2).ToString()].Value = data[i].Hrult;
                    worksheet.Cells["AO" + (i + 2).ToString()].Style.Font.Size = 8;

                }
                package.Save();
            }

            byte[] fileBytes = File.ReadAllBytes(Path.Combine(WebRootFolder, FileName));

            if (file.Exists)
                file.Delete();

            return fileBytes;
        }

        public byte[] ExportaPadraoGasNatural(List<_11_LoteAtivoB> data, IEnumerable<dynamic> lote)
        {
            var l = lote.ToList();
            
            FileName = @"" + DateTime.Now.ToString("yyMMddHHmmss") + "_Relatório_Lote_" + l[0].LoteNum + ".xlsm";
            File.Copy(Path.Combine(WebRootFolder, @"formatoGasNatural.xlsm"), Path.Combine(WebRootFolder, FileName));

            FileInfo file = new FileInfo(Path.Combine(WebRootFolder, FileName));

            // lógica da data

            using (ExcelPackage package = new ExcelPackage(file))
            {
                // ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("qExcel");
                ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();

                worksheet.Cells["C4"].Value = data.Count();
                worksheet.Cells["D5"].Value = l[0].Meta;
                
                worksheet.Cells["F3"].Value = l[0].DataLote.ToString("dd/MM/yy");

                worksheet.Cells["F4"].Value = l[0].DataEntrega.ToString("dd/MM/yy");

                worksheet.Cells["I3"].Value = l[0].Ge;

                for (int i = 0; i < data.Count(); i++)
                {
                    worksheet.Cells["B" + (i + 7).ToString()].Value = data[i].Bairro;
                    worksheet.Cells["C" + (i + 7).ToString()].Value = data[i].Endereco;
                    worksheet.Cells["D" + (i + 7).ToString()].Value = data[i].Pt;
                    worksheet.Cells["E" + (i + 7).ToString()].Value = data[i].CasaStatus2;
                    worksheet.Cells["F" + (i + 7).ToString()].Value = data[i].UltMotivo;
                    worksheet.Cells["G" + (i + 7).ToString()].Value = data[i].Agult;
                    worksheet.Cells["H" + (i + 7).ToString()].Value = data[i].Dtult;
                    worksheet.Cells["I" + (i + 7).ToString()].Value = data[i].Hrult;
                    worksheet.Cells["J" + (i + 7).ToString()].Value = data[i].NomeTlf;
                    worksheet.Cells["K" + (i + 7).ToString()].Value = data[i].Parentesco;
                }
                worksheet.Select("A1");
                package.Save();

            }

            byte[] fileBytes = File.ReadAllBytes(Path.Combine(WebRootFolder, FileName)); ;
            if (file.Exists)
                file.Delete();

            return fileBytes;
        }
    }
}
