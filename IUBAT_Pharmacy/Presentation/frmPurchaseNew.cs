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
    public partial class frmPurchaseNew : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        public frmPurchaseNew()
        {
            InitializeComponent();
        }

        DAL.clsProduct pd2 = new DAL.clsProduct();
        DAL.clsEmployee em = new DAL.clsEmployee();

        private void frmPurchaseNew_Load(object sender, EventArgs e)
        {

            cmbProduct.setDataSource(pd2.Select());
            txtEmployee.txtTextValue = Presentation.frmLogIn.loguname;
            txtEmployee.Enabled = false;
            dptDateTime.Value = DateTime.Now;
            cmbVat.txtComboText = "0";
           
        }


        private void btnPurchase_Click(object sender, EventArgs e) // Calculation of Ammount
        {
            double total = 0;

            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                total += Convert.ToDouble(dgvData.Rows[i].Cells["colSubTotal"].Value);
            }
            lblTotal.Text = string.Format("Total (BDT/TAKA) : {0}", total);

        }

        private void btnAdd_Click(object sender, EventArgs e) //Add To the Purchse List
        {

            if (!string.IsNullOrWhiteSpace(cmbRate.txtComboText) && !string.IsNullOrWhiteSpace(cmbVat.txtComboText) && !string.IsNullOrWhiteSpace(txtQty.txtTextValue))
            {

                lblSubtotal.Text = ((Convert.ToInt32(txtQty.txtTextValue) * Convert.ToInt32(cmbRate.txtComboText) * Convert.ToDouble(cmbVat.txtComboText)) + (Convert.ToInt32(txtQty.txtTextValue) * Convert.ToInt32(cmbRate.txtComboText))).ToString();
            }


            if (colProduct.Index == 0 && colDiscount.Index == 1 && colQty.Index == 2 && colNumber.Index == 3 && colRate.Index == 4 && colVat.Index == 5 && colSubTotal.Index == 6 && colId.Index == 7 && colDiscountId.Index == 8 && colCodeId.Index == 9 && colRateId.Index == 10 && colVatId.Index == 11)
            {
                dgvData.Rows.Add(cmbProduct.txtComboText, cmbDiscount.txtComboText, txtQty.txtIntValue, cmbCode.txtComboText, cmbRate.txtComboText, cmbVat.txtComboText = "0", lblSubtotal.Text, cmbProduct.txtTextValueInt, cmbDiscount.txtTextValueInt = pd2.DiscountId, cmbCode.txtComboText = pd2.Code, cmbRate.txtTextValueDouble = pd2.ListPrice, cmbVat.txtTextValueInt = 0);

            }
            else
            {
                MessageBox.Show("");
            }

            double total = 0; //Counting Total Ammount

            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                total += Convert.ToDouble(dgvData.Rows[i].Cells["colSubTotal"].Value);
            }
            lblTotal.Text = string.Format("Total (BDT/TAKA) : {0}", total);



            cmbProduct.txtComboText = "";
            cmbCode.txtComboText = "";
            cmbRate.txtComboText = "";
            cmbVat.txtComboText = "0";
            cmbDiscount.txtComboText = "";
            txtQty.txtTextValue = "";
            dptDateTime.Value = DateTime.Now;
            cmbProduct.Focus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int er = 0;

            if (dgvData.Rows.Count < 1)
            {
                er++;
                MessageBox.Show("Puchase table Empty");
                return;
            }

            if (er > 0)
            {
                return;
            }

            DAL.clsPurchase prc = new DAL.clsPurchase();
            


            if (er == 0)
            {
                prc.DateTime = dptDateTime.Value.Date;
                prc.EmployeeId = Presentation.frmLogIn.logid;

                if (prc.Insert())
                {
                    MessageBox.Show("Purchase Details Inserted !!");
                }

                else
                {
                    MessageBox.Show(prc.Error);
                }
            }

            DAL.clsPurchaseDetails prcd = new DAL.clsPurchaseDetails();
            er += txtQty.txtValidate();


            if (er > 0)
            {

                for (int i = 0; i < dgvData.Rows.Count; i++) //PurchaseDetailsInsert Start
                {
                    prcd.PurchaseId = prc.Identity;
                    try
                    {
                        prcd.ProductId = Convert.ToInt32(dgvData.Rows[i].Cells["colId"].Value);
                        prcd.DiscountId = Convert.ToInt32(dgvData.Rows[i].Cells["colDiscountId"].Value);
                        prcd.Qty = Convert.ToInt32(dgvData.Rows[i].Cells["colQty"].Value);
                        prcd.Rate = Convert.ToInt32(dgvData.Rows[i].Cells["colRateId"].Value);
                        prcd.Vat = Convert.ToDouble(dgvData.Rows[i].Cells["colVatId"].Value);
                        prcd.Number = dgvData.Rows[i].Cells["colCodeId"].Value.ToString();
                        prcd.Subtotal = dgvData.Rows[i].Cells["colSubTotal"].Value.ToString();
                    }
                    catch
                    {

                    }
                    if (prcd.Insert())
                    {
                        MessageBox.Show(@"Purchase Details inserted!! 
                                          Click OK For Report");
                    }
                    else
                    {
                        MessageBox.Show(prcd.Error);
                    }
                }

                printCustomerPurchase(prc.Identity);

                    cmbProduct.txtComboText = "";
                    cmbCode.txtComboText = "";
                    txtQty.txtTextValue = "";
                    cmbRate.txtComboText = "";
                    cmbVat.txtComboText = "0";
                    cmbDiscount.txtComboText = "";
                    dgvData.Rows.Clear();
                    cmbProduct.Focus();
                }

        }

        private void printCustomerPurchase(int p) //Print Report 
        {

            LoadReport("rptPurchaseSingle", "Purchase Invoice Report", new DAL.clsPurchase().CustomerPurchaseReport(p).Tables[0]);
        }
        public void LoadReport(string fileName, string Name, DataTable dt) //Print Report
        {
            Reports.frmReport r = new Reports.frmReport();

            r.reportViewer1.Reset();
            r.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            r.reportViewer1.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory + "Reports/" + fileName + ".rdlc";
            ReportDataSource reportDatasourse = new ReportDataSource();
            reportDatasourse.Name = "DataSet1";
            //reportDatasourse.Value = dgvData.DataSource;
            reportDatasourse.Value = dt;
            r.reportViewer1.LocalReport.SetParameters(new ReportParameter("Company", IUBAT_Pharmacy.Properties.Settings.Default.Company));
            r.reportViewer1.LocalReport.SetParameters(new ReportParameter("Address1", IUBAT_Pharmacy.Properties.Settings.Default.Address1));
            r.reportViewer1.LocalReport.SetParameters(new ReportParameter("Address2", IUBAT_Pharmacy.Properties.Settings.Default.Address2));
            r.reportViewer1.LocalReport.SetParameters(new ReportParameter("Name", Name));
            r.reportViewer1.LocalReport.SetParameters(new ReportParameter("Date", DateTime.Now.ToString()));

            r.reportViewer1.LocalReport.DataSources.Add(reportDatasourse);
            r.reportViewer1.RefreshReport();
            r.Show();
        }
            

        private void btnClear_Click(object sender, EventArgs e) //Clear
        {

            cmbProduct.txtComboText = "";
            cmbCode.txtComboText = "";
            cmbRate.txtComboText = "";
            cmbVat.txtComboText = "0";
            dgvData.Rows.Clear();
            txtQty.txtTextValue = "";
            cmbDiscount.txtComboText = "";
            cmbProduct.Focus();

        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            pd2.Id = cmbProduct.txtTextValueInt;
            pd2.SelectById();
            
            cmbDiscount.txtTextValueInt = pd2.DiscountId;
            cmbDiscount.txtComboText = pd2._discount;

            cmbRate.txtTextValueDouble = pd2.ListPrice;
            cmbRate.txtComboText = pd2._rate;

            cmbCode.txtComboText = pd2._code;
            cmbCode.txtComboText = pd2.Code;

            //cmbVat.txtComboText = pd2._vat.ToString();
            //cmbVat.txtTextValueDouble = pd2.Vat;

        }

    }
}               
            
    


            


    
