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
    public partial class frmSaleDetailsNew : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        DAL.clsProduct pd = new DAL.clsProduct();

        DAL.clsPaymentMethod pm = new DAL.clsPaymentMethod();

        DAL.clsSaleStatus st = new DAL.clsSaleStatus();
        public frmSaleDetailsNew()
        {
            InitializeComponent();
        }

        private void frmSaleDetailsNew_Load(object sender, EventArgs e)
        {
            cmbProduct.setDataSource(pd.Select());
            txtEmployee.txtTextValue = Presentation.frmLogIn.loguname;
            txtEmployee.Enabled = false;

            cmbPaymentMethod.setDataSource(pm.Select());
            cmbPaymentMethod.txtComboText = "BDT(TAKA)";

            cmbSaleStatus.setDataSource(st.Select());
            cmbSaleStatus.txtComboText = "SOLD";
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtRate.txtTextValue) && !string.IsNullOrWhiteSpace(txtVat.txtTextValue) && !string.IsNullOrWhiteSpace(txtQuantity.txtTextValue))
            {

               lblSubTotal.Text = ((Convert.ToInt32(txtQuantity.txtTextValue) * Convert.ToInt32(txtRate.txtTextValue) * Convert.ToDouble(txtVat.txtTextValue)) + (Convert.ToInt32(txtQuantity.txtTextValue) * Convert.ToInt32(txtRate.txtTextValue))).ToString();

            }

            if (colProduct.Index == 0 && colCompany.Index == 1 && colNumber.Index == 2 && colQty.Index == 3 && colRate.Index == 4 && colVat.Index == 5 && colDiscount.Index == 6 && colSaleStatus.Index == 7 && colPaymentMethod.Index == 8 && colSubTotal.Index == 9 && colId.Index == 10 && colCompanyId.Index == 11 && colCodeId.Index == 12 && colDiscountId.Index == 13 && colSaleStatusId.Index == 14 && colPaymentId.Index == 15)
            {
                dgvData.Rows.Add(cmbProduct.txtComboText, cmbCompany.txtComboText, cmbNumber.txtComboText = pd.Code, txtQuantity.txtIntValue, txtRate.txtDoubleValue = pd.ListPrice, txtVat.txtDoubleValue = pd.Vat, cmbDiscount.txtComboText = pd._discount, cmbSaleStatus.txtComboText, cmbPaymentMethod.txtComboText, lblSubTotal.Text, cmbProduct.txtTextValueInt, cmbCompany.txtTextValueInt = pd.CompanyId, cmbNumber.txtComboText = pd.Code, cmbDiscount.txtTextValueInt = pd.DiscountId, cmbSaleStatus.txtTextValueInt, cmbPaymentMethod.txtTextValueInt);

            }

            double total = 0;

            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                total += Convert.ToDouble(dgvData.Rows[i].Cells["colSubTotal"].Value);
            }
            lblTotal.Text = string.Format("Total (BDT/TAKA) : {0}", total);
            
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            int er = 0;

            if (dgvData.Rows.Count < 1)
            {
                er++;
                MessageBox.Show("Sale table Empty");
                return;
            }

            if (er > 0)
            {
                return;
            }

           DAL.clsSale sl = new DAL.clsSale();
           
            if (er == 0)
            {
                sl.DateTime = dptDateTime.Value;
                sl.EmployeeId = Presentation.frmLogIn.logid;

                if(sl.Insert())
                {
                    MessageBox.Show("sell Details Inserted !!");
                }

                else
                {
                    MessageBox.Show(sl.Error);
                }
            }

            DAL.clsSaleDetails sld = new DAL.clsSaleDetails();
            er += txtQuantity.txtValidate();

                if (er == 0)
                {
                    for (int i = 0; i < dgvData.Rows.Count; i++)
                    {
                        sld.SaleId = sl.Identity;
                        try
                        {
                            sld.ProductId = Convert.ToInt32(dgvData.Rows[i].Cells["colId"].Value);
                            sld.DiscountId = Convert.ToInt32(dgvData.Rows[i].Cells["colDiscountID"].Value);
                            sld.CompanyId = Convert.ToInt32(dgvData.Rows[i].Cells["colCompanyId"].Value);
                            sld.Qty = Convert.ToInt32(dgvData.Rows[i].Cells["colQty"].Value);
                            sld.Rate = Convert.ToInt32(dgvData.Rows[i].Cells["colRate"].Value);
                            sld.Vat = Convert.ToDouble(dgvData.Rows[i].Cells["colVat"].Value);
                            sld.Number = dgvData.Rows[i].Cells["colCodeId"].Value.ToString();
                            sld.SaleStatusId = Convert.ToInt32(dgvData.Rows[i].Cells["colSaleStatusId"].Value);
                            sld.SubTotal = Convert.ToDouble(dgvData.Rows[i].Cells["colSubTotal"].Value);
                            sld.PaymentMethodId = Convert.ToInt32(dgvData.Rows[i].Cells["colPaymentId"].Value);
                        }

                        catch
                        {
                        }
                        if (sld.Insert())
                        {
                            MessageBox.Show(@"Sale Details inserted!! 
                                          Click OK For Report");
                        }
                        else
                        {
                            MessageBox.Show(sld.Error);
                        }
                    }

                    PrintCustomerInvoice(sl.Identity);

                        cmbProduct.txtComboText = "";
                        cmbCompany.txtComboText = "";
                        cmbNumber.txtComboText = "";
                        txtQuantity.txtTextValue = "";
                        txtRate.txtTextValue = "";
                        txtVat.txtTextValue = "";
                        cmbDiscount.txtComboText = "";
                        cmbSaleStatus.txtComboText = "SOLD";
                        cmbPaymentMethod.txtComboText = "BDT(TAKA)";
                        lblSubTotal.Text = "";
                        dgvData.Rows.Clear();
                        cmbProduct.Focus();
                    }
        }



        private void PrintCustomerInvoice(int c)
        {
            LoadReport("rptSaleSingle", "Customer Invoice Report", new DAL.clsSale().CustomerPurchaseReport(c).Tables[0]);
        }

        public void LoadReport(string fileName, string Name, DataTable dt)
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



        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbProduct.txtComboText = "";
            cmbCompany.txtComboText = "";
            cmbNumber.txtComboText = "";
            txtQuantity.txtTextValue = "";
            txtRate.txtTextValue = "";
            txtVat.txtTextValue = "";
            cmbDiscount.txtComboText = "";
            cmbSaleStatus.txtComboText = "SOLD";
            cmbPaymentMethod.txtComboText = "BDT(TAKA)";
            lblSubTotal.Text = "";
            dgvData.Rows.Clear();
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            pd.Id = cmbProduct.txtTextValueInt;
            pd.SelectById();

            cmbCompany.txtTextValueInt = pd.CompanyId;
            cmbCompany.txtComboText = pd._company;

            cmbNumber.txtComboText = pd.Code;

            cmbDiscount.txtComboText = pd._discount;
            cmbDiscount.txtTextValueInt = pd.DiscountId;
            txtRate.txtDoubleValue = pd.ListPrice;
            txtVat.txtDoubleValue = pd.Vat;
            //cmbPaymentMethod.setDataSource(pm.Select());
            //cmbSaleStatus.setDataSource(st.Select());


        }

        private void cmbSaleStatus_Load(object sender, EventArgs e)
        {

        }
    }
}
