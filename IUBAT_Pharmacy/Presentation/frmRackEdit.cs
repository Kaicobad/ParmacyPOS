using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmRackEdit : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        DAL.clsRack rc = new DAL.clsRack();
        public frmRackEdit(int id)
        {
            InitializeComponent();

            rc.Id = id;
            if (rc.SelectById())
            {
                txtName.txtTextValue = rc.Name;
                cmbProduct.txtComboText = rc.ProductId.ToString();
            }
            else
            {
                MessageBox.Show(rc.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int er = 0;
            er += txtName.txtValidate();
            er += cmbProduct.txtValidate();

            if (er == 0)
            {
                rc.Name = txtName.txtTextValue;
                cmbProduct.txtComboText = rc.ProductId.ToString();

                if (rc.Update())
                {
                    MessageBox.Show("Rack Info Updated");
                    txtName.Focus();
                }
                else
                {
                    MessageBox.Show(rc.Error);
                }
            }
        }
    }
}
