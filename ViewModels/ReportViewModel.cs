using InformeProyectos.Services.DataSet;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformeProyectos.ViewModels
{
    class ReportViewModel:ViewModelBase
    {
        public string PDFData { set; get; }
        ReportViewer myReport { set; get; }
        ReportDataSource rds { set; get; }

        public ReportViewModel()
        {
            myReport = new ReportViewer();
            rds = new ReportDataSource();
        }

        public void GenerarInformeDpto(int idDpto)
        {
            rds.Name = "InformeDpto";
            rds.Value = DataSetHandler.GetDataByIdDpto(idDpto);
            myReport.LocalReport.DataSources.Add(rds);
            myReport.LocalReport.ReportPath = "../../Reporting/InformeDpto.rdlc";
            byte[] PDFBytes = myReport.LocalReport.Render(format: "PDF", deviceInfo: "");
            PDFData = "data:application/pdf;base64," + Convert.ToBase64String(PDFBytes);
        }

        public void GenerarInformeFechas(DateTime fecha1, DateTime fecha2)
        {
            rds.Name = "InformeFechas";
            rds.Value = DataSetHandler.GetDataByFechas(fecha1, fecha2);
            myReport.LocalReport.DataSources.Add(rds);
            myReport.LocalReport.ReportPath = "../../Reporting/InformeFechas.rdlc";
            byte[] PDFBytes = myReport.LocalReport.Render(format: "PDF", deviceInfo: "");
            PDFData = "data:application/pdf;base64," + Convert.ToBase64String(PDFBytes);
        }

        public void GenerarInformeIdProyecto(int idProyecto)
        {
            rds.Name = "InformeProyecto";
            rds.Value = DataSetHandler.GetDataByIdProyecto(idProyecto);
            myReport.LocalReport.DataSources.Add(rds);
            myReport.LocalReport.ReportPath = "../../Reporting/InformeProyecto.rdlc";
            byte[] PDFBytes = myReport.LocalReport.Render(format: "PDF", deviceInfo: "");
            PDFData = "data:application/pdf;base64," + Convert.ToBase64String(PDFBytes);
        }

        public void GenerarInformeProyectoDpto(int idProyecto, int idDpto)
        {
            rds.Name = "InformeProyecto";
            rds.Value = DataSetHandler.GetDataByProyectoDpto(idProyecto, idDpto);
            myReport.LocalReport.DataSources.Add(rds);
            myReport.LocalReport.ReportPath = "../../Reporting/InformeProyecto.rdlc";
            byte[] PDFBytes = myReport.LocalReport.Render(format: "PDF", deviceInfo: "");
            PDFData = "data:application/pdf;base64," + Convert.ToBase64String(PDFBytes);
        }
    }
}
