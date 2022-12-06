using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmPowerEdit : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        DAL.clsPower pr = new DAL.clsPower();
        public frmPowerEdit(int id)
        {
            InitializeComponent();
            pr.Id = id;
            if (pr.SelectById())
            {
                txtName.txtTextValue = pr.Name;
            }
            else
            {
                MessageBox.Show(pr.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int er = 0;
            er += txtName.txtValidate();

            if (er == 0)
            {
                pr.Name = txtName.txtTextValue;

                if (pr.Update())
                {
                    MessageBox.Show("Power Info Updated");
                    txtName.Focus();
                }

                else
                {
                    MessageBox.Show(pr.Error);
                }
            }
        }
    }
}
