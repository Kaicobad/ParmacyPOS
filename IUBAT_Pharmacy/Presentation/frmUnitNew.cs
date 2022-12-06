using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmUnitNew : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        public frmUnitNew()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAL.clsUnit u = new DAL.clsUnit();
            int er = 0;
            er += txtName.txtValidate();
            er += txtDescription.txtValidate();
            er += txtPrimaryQty.txtValidate();

            if (er == 0)
            {
                u.Name = txtName.txtTextValue;
                u.Description = txtDescription.txtTextValue;
                u.PrimaryQty = txtPrimaryQty.txtIntValue;

                if (u.Insert())
                {
                    MessageBox.Show("New Unit Inserted !!");
                    txtName.txtTextValue = "";
                    txtDescription.txtTextValue = "";
                    txtPrimaryQty.txtTextValue = "";
                    txtName.Focus();
                }

                else
                {
                    MessageBox.Show(u.Error);
                }
            }
        }
    }
}
