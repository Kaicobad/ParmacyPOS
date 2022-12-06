using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmPaymentMethodNew : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        public frmPaymentMethodNew()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAL.clsPaymentMethod pm = new DAL.clsPaymentMethod();
            int er = 0;
            er += TxtName.txtValidate();

            if (er == 0)
            {
                pm.Name = TxtName.txtTextValue;
                pm.Company = txtCompany.txtTextValue;

                if (pm.Insert())
                {
                    MessageBox.Show("New Payment Methode is Inserted !!");
                    TxtName.txtTextValue = "";
                    txtCompany.txtTextValue = "";
                }
                else
                {
                    MessageBox.Show(pm.Error);
                }
            }
        }
    }
}
