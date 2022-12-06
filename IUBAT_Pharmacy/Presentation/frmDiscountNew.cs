using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmDiscountNew : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        public frmDiscountNew()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAL.clsDiscount ds = new DAL.clsDiscount();
            int er = 0;
            er += txtDiscount.txtValidate();
            er += txtPersentage.txtValidate();

            if (er == 0)
            {
                ds.Name = txtDiscount.txtTextValue;
                //ds.Persentage = txtPersentage.txtDoubleValue;
                ds.Persentage = txtPersentage.txtFloatValue;
                //ds.Persentage = txtPersentage.txtPersentValue;

                if (ds.Insert())
                {
                    MessageBox.Show("Discount type Inserted !!");
                    txtDiscount.txtTextValue = "";
                    txtPersentage.txtTextValue = "";
                    txtDiscount.Focus();
                }
                else
                {
                    MessageBox.Show(ds.Error);
                }
            }
        }
    }
}
