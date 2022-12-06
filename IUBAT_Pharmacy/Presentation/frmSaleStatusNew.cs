using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmSaleStatusNew : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        public frmSaleStatusNew()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAL.clsSaleStatus st = new DAL.clsSaleStatus();
            int er = 0;
            er += txtName.txtValidate();

            if (er == 0)
            {
                st.Name = txtName.txtTextValue;
                st.Description = txtDescription.txtTextValue;

                if (st.Insert())
                {
                    MessageBox.Show("New User Defined Sale Status Inserted !!");
                    txtName.txtTextValue = "";
                    txtDescription.txtTextValue = "";
                    txtName.Focus();
                }
                else
                {
                    MessageBox.Show(st.Error);
                }
            }
        }
    }
}
