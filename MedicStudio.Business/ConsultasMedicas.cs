using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.IO;
using System.Drawing;

namespace MedicStudio.Business
{
    public class ConsultasMedicas : BaseBusinessObject
    {
        private Data.ConsultasMedicas Data
        {
            get { return this.DataObject as Data.ConsultasMedicas; }
        }

        public ConsultasMedicas()
        {
            this.DataObject = new Data.ConsultasMedicas();
        }

        public List<Entities.ConsultasMedicas> ListaConsulta (string buscar)
        {
            return this.Data.Consultas(buscar);
        }
        public void Exportar(string buscar , string archivo)
        {
            OfficeOpenXml.ExcelPackage xlsx = new OfficeOpenXml.ExcelPackage();
            OfficeOpenXml.ExcelWorksheet sheet = xlsx.Workbook.Worksheets.Add("Hoja 1");

            //Titulo
            sheet.Cells["B2:H2"].Merge = true;
            sheet.Cells["B2:H2"].Value = string.Format("CIAC");
            sheet.Cells["B2:H2"].Style.Font.Bold = true;
             sheet.Cells["B2:F2"].Style.Font.Color.SetColor(Color.Red);
            sheet.Cells["B2:H2"].Style.Font.Size = 40;
            sheet.Cells["B2:H2"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;


            //Subtitulo
            sheet.Cells["B3:H3"].Merge = true;
            sheet.Cells["B3:H3"].Value = string.Format("Reporte de Consultas Medicas");
            sheet.Cells["B3:H3"].Style.Font.Bold = true;
            sheet.Cells["B3:F3"].Style.Font.Color.SetColor(Color.Black);
            sheet.Cells["B3:H3"].Style.Font.Size = 24;
            sheet.Cells["B3:H3"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

            //Subtitulo
            sheet.Cells["B4:H4"].Merge = true;
            sheet.Cells["B4:H4"].Value = string.Format("Filtrado mediante {0}", buscar);
            sheet.Cells["B4:H4"].Style.Font.Bold = true;
            sheet.Cells["B4:F4"].Style.Font.Color.SetColor(Color.Gray);
            sheet.Cells["B4:H4"].Style.Font.Size = 16;
            sheet.Cells["B4:H4"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

            //filas

            sheet.Cells["B7"].Value = "ID Medico";
            sheet.Cells["C7"].Value = "Nombre Medico";
            sheet.Cells["D7"].Value = "Área";
            sheet.Cells["E7"].Value = "ID Paciente";
            sheet.Cells["F7"].Value = "Nombre Paciente";
            sheet.Cells["G7"].Value = "ID Consulta";
            sheet.Cells["H7"].Value = "Fecha";
            sheet.Cells["B7:H7"].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
            sheet.Cells["B7:H7"].Style.Border.Top.Color.SetColor(Color.Black);
            sheet.Cells["B7:H7"].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
            sheet.Cells["B7:H7"].Style.Border.Bottom.Color.SetColor(Color.Black);
            sheet.Cells["B7:H7"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;


            List<Entities.ConsultasMedicas> list = this.ListaConsulta(buscar);
            int filaInicial = 8;
            bool color = false;
            foreach (Entities.ConsultasMedicas item in list)
            {

                sheet.Cells["B" + filaInicial.ToString()].Value = item.IdMedico;
                sheet.Cells["C" + filaInicial.ToString()].Value = item.NombreMedico;
                sheet.Cells["D" + filaInicial.ToString()].Value = item.Area;
                sheet.Cells["E" + filaInicial.ToString()].Value = item.IdPaciente;
                sheet.Cells["F" + filaInicial.ToString()].Value = item.NombrePaciente;
                sheet.Cells["G" + filaInicial.ToString()].Value = item.IdConsulta;
                sheet.Cells["H" + filaInicial.ToString()].Value = item.Fecha;
                sheet.Cells["H" + filaInicial.ToString()].Style.Numberformat.Format = "dd-MMM";


                if (color)
                {
                    sheet.Cells[string.Format("B{0}:H{0}", filaInicial)].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    sheet.Cells[string.Format("B{0}:H{0}", filaInicial)].Style.Fill.BackgroundColor.SetColor(Color.LightSlateGray);
                }
                color = !color;
                ++filaInicial;
            }

            sheet.Column(2).AutoFit();
            sheet.Column(3).AutoFit();
            sheet.Column(4).AutoFit();
            sheet.Column(5).AutoFit();
            sheet.Column(6).AutoFit();
            sheet.Column(7).AutoFit();
            sheet.Column(8).AutoFit();
            sheet.Column(9).AutoFit();



            FileStream f = new System.IO.FileStream(archivo, FileMode.Create);
            xlsx.SaveAs(f);
            xlsx.Dispose();
            f.Close();
            f.Dispose();
            System.Diagnostics.Process.Start(archivo);
        }
    }
}
