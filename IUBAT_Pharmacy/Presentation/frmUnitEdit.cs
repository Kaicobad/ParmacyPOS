using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmUnitEdit : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        DAL.clsUnit u = new DAL.clsUnit();
        public frmUnitEdit(int id)
        {
            InitializeComponent();
            u.Id = id;
            if (u.SelectById())
            {
                txtName.txtTextValue = u.Name;
                txtDescription.txtTextValue = u.Description;
                txtPrimaryQty.txtIntValue = u.PrimaryQty;
            }
            else
            {
                MessageBox.Show(u.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int er = 0;
            er += txtName.txtValidate();
            er += txtDescription.txtValidate();
            er += txtPrimaryQty.txtValidate();

            if (er == 0)
            {
                u.Name = txtName.txtTextValue;
                u.Description = txtDescription.txtTextValue;
                u.PrimaryQty = txtPrimaryQty.txtIntValue;

                if (u.Update())
                {
                    MessageBox.Show("Unit Updated !!");
                    txtName.Focus();
                }

                else
                {
                    MessageBox.Show(u.Error);
                }
            }
            txtName.txtTextValue = "";
            txtDescription.txtTextValue = "";
            txtPrimaryQty.txtTextValue = "" ;
        }
    }
}
