using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmDiscountEdit : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        DAL.clsDiscount ds = new DAL.clsDiscount();

        public frmDiscountEdit(int id)
        {
            InitializeComponent();
            ds.Id = id;
            if (ds.SelectById())
            {
                txtDiscount.txtTextValue = ds.Name;
                txtPersentage.txtFloatValue =  (float)Convert.ToInt32(ds.Persentage);
            }
            else
            {
                MessageBox.Show(ds.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            int er = 0;
            er += txtDiscount.txtValidate();
            er += txtPersentage.txtValidate();

            if (er == 0)
            {
                ds.Name = txtDiscount.txtTextValue;
                //ds.Persentage = txtPersentage.txtDoubleValue;
                ds.Persentage = txtPersentage.txtFloatValue;
                //ds.Persentage = txtPersentage.txtPersentValue;

                if (ds.Update())
                {
                    MessageBox.Show("Discount Info Updated !!");
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
