using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation.Common
{
    public partial class frmDisplay : Form
    {
        public frmDisplay()
        {
            InitializeComponent();
        }

        public void LoadReport(string fileName, string Name, DataTable dt)
        {
            Reports.frmReport r = new Reports.frmReport();

            r.reportViewer1.Reset();
            r.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            r.reportViewer1.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory + "Reports/"+fileName+".rdlc";
            ReportDataSource reportDatasourse = new ReportDataSource();
            reportDatasourse.Name = "DataSet1";
            reportDatasourse.Value = dt;

            r.reportViewer1.LocalReport.SetParameters(new ReportParameter("Company", IUBAT_Pharmacy.Properties.Settings.Default.Company));
            r.reportViewer1.LocalReport.SetParameters(new ReportParameter("Address1", IUBAT_Pharmacy.Properties.Settings.Default.Address1));
            r.reportViewer1.LocalReport.SetParameters(new ReportParameter("Address2", IUBAT_Pharmacy.Properties.Settings.Default.Address2));
            r.reportViewer1.LocalReport.SetParameters(new ReportParameter("Name", Name));
            r.reportViewer1.LocalReport.SetParameters(new ReportParameter("Date", DateTime.Now.ToString()));

            r.reportViewer1.LocalReport.DataSources.Add(reportDatasourse);
            r.reportViewer1.RefreshReport();
            r.Show();
            r.MdiParent = this.MdiParent;
        }
    }
}
