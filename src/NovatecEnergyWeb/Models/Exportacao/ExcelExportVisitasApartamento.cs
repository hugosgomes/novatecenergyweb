using Microsoft.AspNetCore.Hosting;
using NovatecEnergyWeb.Models.StoredProcedures;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.Exportacao
{
    public class ExcelExportVisitasApartamento : IExcelExportVisitasApartamento
    {

        private readonly IHostingEnvironment _hostingEnvironment;
        public string FileName { get; set; }
        private string WebRootFolder;

        public ExcelExportVisitasApartamento(IHostingEnvironment he)
        {
            _hostingEnvironment = he;
            WebRootFolder = _hostingEnvironment.WebRootPath + "\\excel";
        }

        public byte[] ExportaPadraoNovatec(List<Visitas> data)
        {
            FileName = @"" + DateTime.Now.ToString("yyMMddHHmmss") + "_Visitas.xlsx";
            File.Copy(Path.Combine(WebRootFolder, @"formatoNovatecVisitasEndereco.xlsx"), Path.Combine(WebRootFolder, FileName));

            FileInfo file = new FileInfo(Path.Combine(WebRootFolder, FileName));

            using (ExcelPackage package = new ExcelPackage(file))
            {
                // ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("qExcel");
                ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();

                //List<Visitas> visitas = data.ToList();


                for (int i = 0; i < data.Count(); i++)
                {
                   
                    worksheet.Cells["A" + (i + 2).ToString()].Value = data[i].Z;
                    worksheet.Cells["A" + (i + 2).ToString()].Style.Font.Size = 8;
                    worksheet.Cells["B" + (i + 2).ToString()].Value = data[i].D;
                    worksheet.Cells["B" + (i + 2).ToString()].Style.Font.Size = 8;
                    worksheet.Cells["C" + (i + 2).ToString()].Value = data[i].Ar;
                    worksheet.Cells["C" + (i + 2).ToString()].Style.Font.Size = 8;
                    worksheet.Cells["D" + (i + 2).ToString()].Value = data[i].Condominio;
                    worksheet.Cells["D" + (i + 2).ToString()].Style.Font.Size = 8;
                    worksheet.Cells["E" + (i + 2).ToString()].Value = data[i].Complemento;
                    worksheet.Cells["E" + (i + 2).ToString()].Style.Font.Size = 8;
                    worksheet.Cells["F" + (i + 2).ToString()].Value = data[i].Num;
                    worksheet.Cells["F" + (i + 2).ToString()].Style.Font.Size = 8;
                    worksheet.Cells["G" + (i + 2).ToString()].Value = data[i].Bloco;
                    worksheet.Cells["G" + (i + 2).ToString()].Style.Font.Size = 8;
                    worksheet.Cells["H" + (i + 2).ToString()].Value = data[i].Apt;
                    worksheet.Cells["H" + (i + 2).ToString()].Style.Font.Size = 8;
                    worksheet.Cells["I" + (i + 2).ToString()].Value = data[i].DataHora;
                    worksheet.Cells["I" + (i + 2).ToString()].Style.Font.Size = 8;
                    worksheet.Cells["J" + (i + 2).ToString()].Value = data[i].Venda;
                    worksheet.Cells["J" + (i + 2).ToString()].Style.Font.Size = 8;
                    worksheet.Cells["K" + (i + 2).ToString()].Value = data[i].AgVisita;
                    worksheet.Cells["K" + (i + 2).ToString()].Style.Font.Size = 8;
                    worksheet.Cells["L" + (i + 2).ToString()].Value = data[i].TipoVisita;
                    worksheet.Cells["L" + (i + 2).ToString()].Style.Font.Size = 8;
                    worksheet.Cells["M" + (i + 2).ToString()].Value = data[i].Negativa;
                    worksheet.Cells["M" + (i + 2).ToString()].Style.Font.Size = 8;
                    worksheet.Cells["N" + (i + 2).ToString()].Value = data[i].Dx;
                    worksheet.Cells["N" + (i + 2).ToString()].Style.Font.Size = 8;
                    worksheet.Cells["O" + (i + 2).ToString()].Value = data[i].Pt;
                    worksheet.Cells["O" + (i + 2).ToString()].Style.Font.Size = 8;
                    worksheet.Cells["P" + (i + 2).ToString()].Value = data[i].StatusCond;
                    worksheet.Cells["P" + (i + 2).ToString()].Style.Font.Size = 8;
                    worksheet.Cells["Q" + (i + 2).ToString()].Value = data[i].Localidade;
                    worksheet.Cells["Q" + (i + 2).ToString()].Style.Font.Size = 8;
                    worksheet.Cells["R" + (i + 2).ToString()].Value = data[i].Bairro;
                    worksheet.Cells["R" + (i + 2).ToString()].Style.Font.Size = 8;
                    worksheet.Cells["S" + (i + 2).ToString()].Value = data[i].Via;
                    worksheet.Cells["S" + (i + 2).ToString()].Style.Font.Size = 8;
                    worksheet.Cells["T" + (i + 2).ToString()].Value = data[i].Logradouro;
                    worksheet.Cells["T" + (i + 2).ToString()].Style.Font.Size = 8;
                    
                }
                package.Save();
            }

            byte[] fileBytes = File.ReadAllBytes(Path.Combine(WebRootFolder, FileName));

            if (file.Exists)
                file.Delete();

            return fileBytes;
        }





    }
}
