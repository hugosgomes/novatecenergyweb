using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using NovatecEnergyWeb.Models.StoredProcedures;
using System.IO;
using OfficeOpenXml;
using NovatecEnergyWeb.Models.AdesaoViewModels;

namespace NovatecEnergyWeb.Models.Exportacao
{
    public class EnderecoVisitasDataExporter : IExcelExportaLotePorCliente
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public string FileName { get; set; }
        private string WebRootFolder;

        public EnderecoVisitasDataExporter(IHostingEnvironment he)
        {
            _hostingEnvironment = he;
            WebRootFolder = _hostingEnvironment.WebRootPath + "\\excel";
        }

        public byte[] ExportaPadraoNovatec(List<LotePorCliente> data)
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
                    //worksheet.Cells["A" + (i + 2).ToString()].Value = data[i].Casa;
                    //worksheet.Cells["A" + (i + 2).ToString()].Style.Font.Size = 8;

                   // worksheet.Cells["B" + (i + 2).ToString()].Value = data[i].Lote;
                   // worksheet.Cells["B" + (i + 2).ToString()].Style.Font.Size = 8;

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

                    worksheet.Cells["I" + (i + 2).ToString()].Value = data[i].Pt;
                    worksheet.Cells["I" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["J" + (i + 2).ToString()].Value = data[i].Localidade;
                    worksheet.Cells["J" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["K" + (i + 2).ToString()].Value = data[i].Bairro;
                    worksheet.Cells["K" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["L" + (i + 2).ToString()].Value = data[i].Via;
                    worksheet.Cells["L" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["M" + (i + 2).ToString()].Value = data[i].Logradouro;
                    worksheet.Cells["M" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["N" + (i + 2).ToString()].Value = data[i].CasaStatus;
                    worksheet.Cells["N" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["O" + (i + 2).ToString()].Value = data[i].Visitado;
                    worksheet.Cells["O" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["P" + (i + 2).ToString()].Value = data[i].Contratado;
                    worksheet.Cells["P" + (i + 2).ToString()].Style.Font.Size = 8;

                   // worksheet.Cells["S" + (i + 2).ToString()].Value = data[i].VendaApp;
                   // worksheet.Cells["S" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["Q" + (i + 2).ToString()].Value = data[i].D2;
                    worksheet.Cells["Q" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["R" + (i + 2).ToString()].Value = data[i].Svg;
                    worksheet.Cells["R" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["S" + (i + 2).ToString()].Value = data[i].Sve;
                    worksheet.Cells["S" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["T" + (i + 2).ToString()].Value = data[i].Visitas;
                    worksheet.Cells["T" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["U" + (i + 2).ToString()].Value = data[i].Entrevistas;
                    worksheet.Cells["U" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["V" + (i + 2).ToString()].Value = data[i].VisitasImpr;
                    worksheet.Cells["V" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["W" + (i + 2).ToString()].Value = data[i].VisitasAgendadas;
                    worksheet.Cells["W" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["X" + (i + 2).ToString()].Value = data[i].Ausencias;
                    worksheet.Cells["X" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["Y" + (i + 2).ToString()].Value = data[i].UltMotivo;
                    worksheet.Cells["Y" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["Z" + (i + 2).ToString()].Value = data[i].Agult;
                    worksheet.Cells["Z" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AA" + (i + 2).ToString()].Value = data[i].Dtult;
                    worksheet.Cells["AA" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AB" + (i + 2).ToString()].Value = data[i].StatusCl;
                    worksheet.Cells["AB" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AC" + (i + 2).ToString()].Value = data[i].DtStatusCl;
                    worksheet.Cells["AC" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AD" + (i + 2).ToString()].Value = data[i].Procedencia;
                    worksheet.Cells["AD" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AE" + (i + 2).ToString()].Value = data[i].Zid;
                    worksheet.Cells["AE" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AF" + (i + 2).ToString()].Value = data[i].Did;
                    worksheet.Cells["AF" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AG" + (i + 2).ToString()].Value = data[i].Aid;
                    worksheet.Cells["AG" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AH" + (i + 2).ToString()].Value = data[i].CondId;
                    worksheet.Cells["AH" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AI" + (i + 2).ToString()].Value = data[i].PtId;
                    worksheet.Cells["AI" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AJ" + (i + 2).ToString()].Value = data[i].IdLote;
                    worksheet.Cells["AJ" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AK" + (i + 2).ToString()].Value = data[i].StatusClid;
                    worksheet.Cells["AK" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AL" + (i + 2).ToString()].Value = data[i].ClId;
                    worksheet.Cells["AL" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AM" + (i + 2).ToString()].Value = data[i].CondStatus;
                    worksheet.Cells["AM" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AN" + (i + 2).ToString()].Value = data[i].IdultMotivo;
                    worksheet.Cells["AN" + (i + 2).ToString()].Style.Font.Size = 8;

                    worksheet.Cells["AO" + (i + 2).ToString()].Value = data[i].LoteStatus;
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

            var zonaid = data.FirstOrDefault().Zid;
            if (zonaid == 2)
                File.Copy(Path.Combine(WebRootFolder, @"formatoGasNaturalFluminense.xlsm"), Path.Combine(WebRootFolder, FileName));
            else
                File.Copy(Path.Combine(WebRootFolder, @"formatoGasNaturalMetropolitana.xlsm"), Path.Combine(WebRootFolder, FileName));

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

                worksheet.Cells["I4"].Value = data.FirstOrDefault().Localidade;

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

        public byte[] ExportaAgendaAdesao(List<LotePorEndereco> data, List<LotePorEnderecoExportaAgendaAdesao> data2, IEnumerable<dynamic> lote, FormFiltersAgendaVisitaEnderecosViewModel filtros)
        {
            var l = lote.ToList();
            var enumMeses = (FormFiltersAgendaVisitaEnderecosViewModel.meses) Convert.ToInt32(filtros.Mes);

            //terminar a lógica do nome depois
            FileName = @"" + DateTime.Now.ToString("yyMMddHHmmss") + "_Lote " + l[0].LoteNum + "- Agenda " +enumMeses.ToString()+ " De "+ filtros.Ano+ ".xlsx";

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
                    worksheet.Cells["J" + (i + 4).ToString()].Value = data2[i].EntrevistasD2;
                    worksheet.Cells["M" + (i + 4).ToString()].Value = data2[i].Contratados;
                    worksheet.Cells["N" + (i + 4).ToString()].Value = data2[i].D2;
                    worksheet.Cells["O" + (i + 4).ToString()].Value = data2[i].Svg;
                    worksheet.Cells["P" + (i + 4).ToString()].Value = data2[i].Sve;
                }

                //Remove aba "Import"
                worksheet.Hidden = eWorkSheetHidden.Hidden;
                //worksheet.Hidden = eWorkSheetHidden.VeryHidden;
                //package.Workbook.Worksheets.Delete(worksheet);

                var worksheetAgenda = package.Workbook.Worksheets.Where(c => c.Name == "Agenda").FirstOrDefault();

                worksheetAgenda.Cells["BR1"].Value = l[0].Area;
                worksheetAgenda.Cells["BR2"].Value = l[0].Ge;
                worksheetAgenda.Cells["BR3"].Value = enumMeses + "/" + filtros.Ano;

                
                //deleta linhas restantes
                var ondeComecaDelecao = 7 + (data.Count * 4);
                var qtdLinhasDelecao  = worksheetAgenda.Cells["A"+ ondeComecaDelecao.ToString()+ ":G410"].Rows;
                worksheetAgenda.DeleteRow(ondeComecaDelecao, qtdLinhasDelecao);

                worksheetAgenda.Select("B7");
                package.Save();        
            }

            byte[] fileBytes = File.ReadAllBytes(Path.Combine(WebRootFolder, FileName));
            if (file.Exists)
                file.Delete();

            return fileBytes;
        }

    }
}
