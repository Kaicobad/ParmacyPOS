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
    public partial class frmPurchase : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public DateTime DateTimeFrom { get; set; }
        public DateTime DateTimeTo { get; set; }
        ////public int PurchaseIdIndex { get; set; }
        //public int PurchaseColumnId { get; set; }

        public frmPurchase()
        {
            InitializeComponent();
        }



        private void btnNew_Click(object sender, EventArgs ex)
        {
            new Presentation.frmPurchaseNew().ShowDialog();
            btnSearch.PerformClick();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsPurchaseDetails prcd = new DAL.clsPurchaseDetails();

            prcd.PurchaseId = txtTextInt.txtIntValue;
            dgvData.DataSource = prcd.Select().Tables[0];
            dgvData2.DataSource = prcd.SelectProductCount().Tables[0];

            //DAL.clsPurchase pr = new DAL.clsPurchase();
            //dgvData.DataSource = pr.Select().Tables[0];



            if (chkDatetime.Checked == true) //Date To Date Search
            {
                DateTimeFrom = dptDateTimeFrom.Value.Date;
                DateTimeTo = dptDateTimeTo.Value.Date;

                if (DateTimeFrom <= DateTimeTo && DateTimeTo >= DateTimeFrom)
                {
                    try
                    {
                        dgvData.DataSource = prcd.Select(" and pr.dateTime between '" + DateTimeFrom.ToString() + "' and '" + DateTimeTo.ToString() + "'").Tables[0];
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


            lblProductCount.Text = prcd.Select().Tables[0].Rows.Count.ToString(); //product Registred

            int sum = 0;
            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvData.Rows[i].Cells["colSubTotal"].Value);
            }
            lblTotal.Text = string.Format("{0}", sum);



            lblQuantity.Text = prcd.Select().Tables[0].Columns.Count.ToString(); //total Purchased
            int sum2 = 0;
            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                sum2 += Convert.ToInt32(dgvData.Rows[i].Cells["colQty"].Value);
            }
            lblQuantity.Text = "Total Purchased Quantity :" + string.Format("{0}", sum2);


        }

  



        private void frmPurchase_Load(object sender, EventArgs e)
        {
            DAL.clsPurchaseDetails prcd = new DAL.clsPurchaseDetails();
            dgvData.DataSource = prcd.Select().Tables[0];
            btnSearch.PerformClick();



            lblProductCount.Text = prcd.Select().Tables[0].Rows.Count.ToString(); //product Registred

            int sum = 0;
            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvData.Rows[i].Cells["colSubTotal"].Value);
            }
            lblTotal.Text = string.Format("{0}", sum);



            lblQuantity.Text = prcd.Select().Tables[0].Columns.Count.ToString(); //total Purchased
            int sum2 = 0;
            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                sum2 += Convert.ToInt32(dgvData.Rows[i].Cells["colQty"].Value);
            }
            lblQuantity.Text = "Total Purchased Quantity :" + string.Format("{0}", sum2);

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count <= 0)
            {
                return;
            }

            DialogResult dr = MessageBox.Show("Delete Confimation", "Are You Sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr != System.Windows.Forms.DialogResult.Yes)
                return;

            DAL.clsPurchase prc = new DAL.clsPurchase();
            DAL.clsPurchaseDetails prcd = new DAL.clsPurchaseDetails();

            prc.Id = Convert.ToInt32(dgvData.SelectedRows[0].Cells["colPurchaseId"].Value);
            prcd.Id = Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value);

            if (prcd.Delete())
            {
                try
                {
                    prc.Delete();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("purchase Info Deleted ");
                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show(prc.Error);
            }
        }

        private void chkDatetime_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            try
            {
                Reports.frmReport r = new Reports.frmReport();
                r.reportViewer1.Reset();
                r.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                r.reportViewer1.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory + "Reports/rptPurchase.rdlc";
                ReportDataSource reportDatasourse = new ReportDataSource();
                reportDatasourse.Name = "DataSet1";
                reportDatasourse.Value = dgvData.DataSource;

                r.reportViewer1.LocalReport.SetParameters(new ReportParameter("Company", IUBAT_Pharmacy.Properties.Settings.Default.Company));
                r.reportViewer1.LocalReport.SetParameters(new ReportParameter("Address1", IUBAT_Pharmacy.Properties.Settings.Default.Address1));
                r.reportViewer1.LocalReport.SetParameters(new ReportParameter("Address2", IUBAT_Pharmacy.Properties.Settings.Default.Address2));
                r.reportViewer1.LocalReport.SetParameters(new ReportParameter("Name", "Purchase Report"));
                r.reportViewer1.LocalReport.SetParameters(new ReportParameter("Date", DateTime.Now.ToString()));
                r.reportViewer1.LocalReport.DataSources.Add(reportDatasourse);
                r.reportViewer1.RefreshReport();
                r.Show();
                r.MdiParent = this.MdiParent;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}