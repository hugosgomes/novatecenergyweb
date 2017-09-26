using Microsoft.AspNetCore.Hosting;
using NovatecEnergyWeb.Models.StoredProcedures;
using NovatecEnergyWeb.Models.ViewModels.AdesaoViewModels;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.Exportacao
{
    public class ExcelExportVisitaEnderecoCondominio : IExcelExportVisitaEnderecoCondominio
    {

        private readonly IHostingEnvironment _hostingEnvironment;
        public string FileName { get; set; }
        private string WebRootFolder;

        public ExcelExportVisitaEnderecoCondominio(IHostingEnvironment he)
        {
            _hostingEnvironment = he;
            WebRootFolder = _hostingEnvironment.WebRootPath + "\\excel";
        }

        public byte[] ExportaAgendaGasNaturalEnderecoCondominio(List<VisitaEndereco> data, 
            List<CondEnderecoExportaAgendaAdesao> data2,
            _12Lotes lote, string mes, string ano)
        {

            var enumMeses = (FormFiltersAgendaVisitaEnderecosViewModel.meses)Convert.ToInt32(mes);


            FileName = @"" + DateTime.Now.ToString("yyMMddHHmmss") + "_Lote " + lote.LoteNum + "- Agenda " + enumMeses.ToString() + " De " + ano + ".xlsx";
            File.Copy(Path.Combine(WebRootFolder, @"formatoAgendaAdesao.xlsx"), Path.Combine(WebRootFolder, FileName));
            FileInfo file = new FileInfo(Path.Combine(WebRootFolder, FileName));


            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Where(c => c.Name == "Import").FirstOrDefault(); //

                for (int i = 0; i < data.Count(); i++)
                {
                    worksheet.Cells["A" + (i + 4).ToString()].Value = data[i].Endereco;
                    worksheet.Cells["B" + (i + 4).ToString()].Value = data[i].Potencial;
                    worksheet.Cells["C" + (i + 4).ToString()].Value = data[i].Agente;
                }

                for (int i = 0; i < data2.Count(); i++)
                {
                    worksheet.Cells["G" + (i + 4).ToString()].Value = data2[i].Endereco;
                    worksheet.Cells["H" + (i + 4).ToString()].Value = data2[i].Datah;
                    worksheet.Cells["I" + (i + 4).ToString()].Value = data2[i].Entrevistas;
                }

                //Remove aba "Import"
                worksheet.Hidden = eWorkSheetHidden.Hidden;
                //worksheet.Hidden = eWorkSheetHidden.VeryHidden;
                //package.Workbook.Worksheets.Delete(worksheet);

                var worksheetAgenda = package.Workbook.Worksheets.Where(c => c.Name == "Agenda").FirstOrDefault();

                worksheetAgenda.Cells["BR1"].Value = lote.Area;
                worksheetAgenda.Cells["BR2"].Value = lote.Ge;
                worksheetAgenda.Cells["BR3"].Value = enumMeses + "/" + ano;


                //deleta linhas restantes
                var ondeComecaDelecao = 7 + (data.Count * 4);
                var qtdLinhasDelecao = worksheetAgenda.Cells["A" + ondeComecaDelecao.ToString() + ":G410"].Rows;
                worksheetAgenda.DeleteRow(ondeComecaDelecao, qtdLinhasDelecao);

                worksheetAgenda.Select("B7");
                package.Save();
            }

            byte[] fileBytes = File.ReadAllBytes(Path.Combine(WebRootFolder, FileName));
            if (file.Exists)
                file.Delete();

            return fileBytes;
        }



        public byte[] ExportaPadraoNovatecCondVisita(List<CondVisita> data)
        {
            FileName = @"" + DateTime.Now.ToString("yyMMddHHmmss") + "_Visitas.xlsx";
            File.Copy(Path.Combine(WebRootFolder, @"formatoNovatecVisitasCondominio.xlsx"), Path.Combine(WebRootFolder, FileName));

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

                    worksheet.Cells["G" + (i + 2).ToString()].Value = (data[i].DataHora != null)? Convert.ToDateTime(data[i].DataHora).ToString("dd/MM/yy hh:mm"):""; 
                    worksheet.Cells["G" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["H" + (i + 2).ToString()].Value = data[i].AgVisita;
                    worksheet.Cells["H" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["I" + (i + 2).ToString()].Value = data[i].Negativa;
                    worksheet.Cells["I" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["J" + (i + 2).ToString()].Value = data[i].Pt;
                    worksheet.Cells["J" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["L" + (i + 2).ToString()].Value = data[i].StatusCond;
                    worksheet.Cells["L" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["K" + (i + 2).ToString()].Value = data[i].TipoCond;
                    worksheet.Cells["K" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["M" + (i + 2).ToString()].Value = data[i].Localidade;
                    worksheet.Cells["M" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["N" + (i + 2).ToString()].Value = data[i].Bairro;
                    worksheet.Cells["N" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["O" + (i + 2).ToString()].Value = data[i].Via;
                    worksheet.Cells["O" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["P" + (i + 2).ToString()].Value = data[i].Logradouro;
                    worksheet.Cells["P" + (i + 2).ToString()].Style.Font.Size = 8;


                }
                package.Save();
            }

            byte[] fileBytes = File.ReadAllBytes(Path.Combine(WebRootFolder, FileName));

            if (file.Exists)
                file.Delete();

            return fileBytes;
        }

        public byte[] ExportaPadraoNovatecPco(List<Pco> data)
        {
            FileName = @"" + DateTime.Now.ToString("yyMMddHHmmss") + "_Pco.xlsx";
            File.Copy(Path.Combine(WebRootFolder, @"formatoNovatecPco.xlsx"), Path.Combine(WebRootFolder, FileName));

            FileInfo file = new FileInfo(Path.Combine(WebRootFolder, FileName));

            using (ExcelPackage package = new ExcelPackage(file))
            {
                // ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("qExcel");
                ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();



                //List<Visitas> visitas = data.ToList();


                for (int i = 0; i < data.Count(); i++)
                {

                    worksheet.Cells["A" + (i + 2).ToString()].Value = data[i].Id;
                    worksheet.Cells["A" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["B" + (i + 2).ToString()].Value = data[i].Num;
                    worksheet.Cells["B" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["C" + (i + 2).ToString()].Value = data[i].Complemento;
                    worksheet.Cells["C" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["D" + (i + 2).ToString()].Value = data[i].Nome;
                    worksheet.Cells["D" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["E" + (i + 2).ToString()].Value = data[i].Status_Item;
                    worksheet.Cells["E" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["F" + (i + 2).ToString()].Value = data[i].Distrede;
                    worksheet.Cells["F" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["G" + (i + 2).ToString()].Value = data[i].Internas_Item;
                    worksheet.Cells["G" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["H" + (i + 2).ToString()].Value = data[i].Energia_Item;
                    worksheet.Cells["H" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["I" + (i + 2).ToString()].Value = data[i].Contato;
                    worksheet.Cells["I" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["J" + (i + 2).ToString()].Value = data[i].Telefone;
                    worksheet.Cells["J" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["L" + (i + 2).ToString()].Value = data[i].Celular;
                    worksheet.Cells["L" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["K" + (i + 2).ToString()].Value = data[i].Email;
                    worksheet.Cells["K" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["M" + (i + 2).ToString()].Value = data[i].Localidade;
                    worksheet.Cells["M" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["N" + (i + 2).ToString()].Value = data[i].Bairro;
                    worksheet.Cells["N" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["O" + (i + 2).ToString()].Value = data[i].LogDesc;
                    worksheet.Cells["O" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["P" + (i + 2).ToString()].Value = data[i].Via;
                    worksheet.Cells["P" + (i + 2).ToString()].Style.Font.Size = 8;
                
                    worksheet.Cells["Q" + (i + 2).ToString()].Value = data[i].Complog;
                    worksheet.Cells["Q" + (i + 2).ToString()].Style.Font.Size = 8;


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
