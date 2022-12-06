using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmPaymentMethodEdit : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        DAL.clsPaymentMethod pm = new DAL.clsPaymentMethod();
        public frmPaymentMethodEdit(int id)
        {
            InitializeComponent();
            pm.Id = id;

            if (pm.SelectById())
            {
                TxtName.txtTextValue = pm.Name;
                txtCompany.txtTextValue = pm.Company;
            }
            else
	        {
                MessageBox.Show(pm.Error);
                this.Close();
	        }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            int er = 0;

            er += TxtName.txtValidate();
            er += txtCompany.txtValidate();

            if (er == 0)
            {
                pm.Name = TxtName.txtTextValue;
                pm.Company = txtCompany.txtTextValue;

                if (pm.Update())
                {
                    MessageBox.Show("New Payment Methode is Updated !!");
                    TxtName.Focus();
                }
                else
                {
                    MessageBox.Show(pm.Error);
                }
            }
        }
    }
}
