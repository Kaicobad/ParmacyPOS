using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmSale : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public DateTime DateTimeFrom { get; set; }
        public DateTime DateTimeTo { get; set; }

        public frmSale()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmSaleDetailsNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsSaleDetails sld = new DAL.clsSaleDetails();
            sld.SaleId = txtSearchInt.txtIntValue;

            dgvData.DataSource = sld.Select().Tables[0];

            dgvData2.DataSource = sld.SelectProductCount().Tables[0];

            if (chkDateTime.Checked == true) //Date To Date Search
            {
                DateTimeFrom = dptDateTimeFrom.Value.Date;
                DateTimeTo = dptDateTimeTo.Value.Date;

                if (DateTimeFrom <= DateTimeTo && DateTimeTo >= DateTimeFrom)
                {
                    try
                    {
                        dgvData.DataSource = sld.Select(" and sl.dateTime between '" + DateTimeFrom.ToString() + "'and'" + DateTimeTo.ToString() + "'").Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                else if (dptDateTimeFrom.Value > dptDateTimeTo.Value || dptDateTimeTo.Value < dptDateTimeFrom.Value)
                {
                    MessageBox.Show("Wrong Formate Of Date to Date Searching !!");
                }

            }

            int sum1 = 0; //quantity of sold Products
            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                sum1 += Convert.ToInt32(dgvData.Rows[i].Cells["colQty"].Value);
            }
            lblSold.Text = "Quantity Of Sold Products :" + string.Format("{0}", sum1);

            int sum = 0; //Amount of taka for sold Products
            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvData.Rows[i].Cells["colSubTotal"].Value);
            }
            lblTotal.Text = string.Format("Total Ammount(BDT/TAKA): {0}", sum);
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            DAL.clsSaleDetails sld = new DAL.clsSaleDetails();
            dgvData.DataSource = sld.Select().Tables[0];
            btnSearch.PerformClick();

            int sum1 = 0; //quantity of sold Products
                  for (int i = 0; i < dgvData.Rows.Count; i++)
                  {
                      sum1 += Convert.ToInt32(dgvData.Rows[i].Cells["colQty"].Value);
                  }
            lblSold.Text = "Quantity Of Sold Products :" + string.Format("{0}", sum1);

            int sum = 0; //Amount of taka for sold Products
                  for (int i = 0; i < dgvData.Rows.Count; i++)
                  {
                      sum += Convert.ToInt32(dgvData.Rows[i].Cells["colSubTotal"].Value);
                  }
            lblTotal.Text = string.Format("Total Ammount(BDT/TAKA): {0}", sum);
            

        }

        private void btnDelete_Click(object sender, EventArgs e) // Delete Operation
        {
            if (dgvData.SelectedRows.Count <= 0)
            {
                return;
            }

            DialogResult dr = MessageBox.Show("Delete Confimation", "Are You Sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr != System.Windows.Forms.DialogResult.Yes)
                return;

            DAL.clsSale sl = new DAL.clsSale();
            DAL.clsSaleDetails sld = new DAL.clsSaleDetails();

            sl.Id = Convert.ToInt32(dgvData.SelectedRows[0].Cells["colSaleId"].Value);
            sld.Id = Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value);

            if (sld.Delete())
            {
                try
                {
                    sl.Delete();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Sale Info Deleted ");
                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show(sl.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Reports.frmReport r = new Reports.frmReport();
                r.reportViewer1.Reset();
                r.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                r.reportViewer1.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory + "Reports/rptSale.rdlc";
                ReportDataSource reportDatasourse = new ReportDataSource();
                reportDatasourse.Name = "DataSet1";
                reportDatasourse.Value = dgvData.DataSource;

                r.reportViewer1.LocalReport.SetParameters(new ReportParameter("Company", IUBAT_Pharmacy.Properties.Settings.Default.Company));
                r.reportViewer1.LocalReport.SetParameters(new ReportParameter("Address1", IUBAT_Pharmacy.Properties.Settings.Default.Address1));
                r.reportViewer1.LocalReport.SetParameters(new ReportParameter("Address2", IUBAT_Pharmacy.Properties.Settings.Default.Address2));
                r.reportViewer1.LocalReport.SetParameters(new ReportParameter("Name", "Sale Details Report"));
                r.reportViewer1.LocalReport.SetParameters(new ReportParameter("Date", DateTime.Now.ToString()));
                r.reportViewer1.LocalReport.DataSources.Add(reportDatasourse);
                r.reportViewer1.RefreshReport();
                r.Show();
                r.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
