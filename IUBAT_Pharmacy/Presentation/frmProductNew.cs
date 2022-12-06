using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmProductEdit : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        public frmProductEdit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAL.clsProduct pd = new DAL.clsProduct();

            int er = 0;

            er += txtName.txtValidate();
            er += txtCode.txtValidate();
            er += cmbGroupId.txtValidate();
            er += cmbCompanyId.txtValidate();
            er += cmbCategoryId.txtValidate();
            er += cmbUnitId.txtValidate();
            er += cmbUnitId.txtValidate();
            er += cmbDiscountId.txtValidate();
            er += cmbSaleStatusId.txtValidate();
            er += txtListPrice.txtValidate();
            er += txtVat.txtValidate();

            if (er == 0)
            {
                pd.Name = txtName.txtTextValue;
                pd.Code = txtCode.txtTextValue;
                pd.GroupId = cmbGroupId.txtTextValueInt;
                pd.PowerId = cmbPowerId.txtTextValueInt;
                pd.CompanyId = cmbCompanyId.txtTextValueInt;
                pd.CategoryId = cmbCategoryId.txtTextValueInt;
                pd.UnitId = cmbUnitId.txtTextValueInt;
                pd.DiscountId = cmbDiscountId.txtTextValueInt;
                pd.SaleStatusId = cmbSaleStatusId.txtTextValueInt;
                pd.ListPrice = txtListPrice.txtDoubleValue;
                pd.Vat = txtVat.txtDoubleValue;
                pd.Remarks = txtRemarks.txtTextValue;

                if (pd.Insert())
                {
                    MessageBox.Show("New Product Inserted !!");
                    txtName.txtTextValue = "";
                    txtCode.txtTextValue = "";
                    cmbGroupId.txtTextValueInt = -1;
                    cmbPowerId.txtTextValueInt = -1;
                    cmbCompanyId.txtTextValueInt = -1;
                    cmbCategoryId.txtTextValueInt = -1;
                    cmbUnitId.txtTextValueInt = -1;
                    cmbDiscountId.txtTextValueInt = -1;
                    cmbSaleStatusId.txtTextValueInt = -1;
                    txtListPrice.txtTextValue = "";
                    txtVat.txtTextValue = "";
                    txtRemarks.txtTextValue = "";
                    txtName.Focus();
                }
                else
                {
                    MessageBox.Show(pd.Error);
                }
            }
        }

        private void frmProductNew_Load(object sender, EventArgs e)
        {
            DAL.clsCategory ctg = new DAL.clsCategory();
            cmbCategoryId.setDataSource(ctg.Select());

            DAL.clsCompany cp = new DAL.clsCompany();
            cmbCompanyId.setDataSource(cp.Select());

            DAL.clsDiscount ds = new DAL.clsDiscount();
            cmbDiscountId.setDataSource(ds.Select());

            DAL.clsGroup gr = new DAL.clsGroup();
            cmbGroupId.setDataSource(gr.Select());

            DAL.clsPower pr = new DAL.clsPower();
            cmbPowerId.setDataSource(pr.Select());

            DAL.clsSaleStatus st = new DAL.clsSaleStatus();
            cmbSaleStatusId.setDataSource(st.Select());

            DAL.clsUnit u = new DAL.clsUnit();
            cmbUnitId.setDataSource(u.Select());
        }
    }
}
