using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmPowerNew : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        public frmPowerNew()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAL.clsPower pr = new DAL.clsPower();
            int er = 0;
            er += txtName.txtValidate();

            if (er == 0)
            {
                pr.Name = txtName.txtTextValue;

                if (pr.Insert())
                {
                    MessageBox.Show("Power Inserted");
                    txtName.txtTextValue = "";
                    txtName.Focus();
                }
            }
        }
    }
}
