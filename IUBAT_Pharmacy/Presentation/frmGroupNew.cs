using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmGroupNew : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        
        public frmGroupNew()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAL.clsGroup gr = new DAL.clsGroup();
            int er = 0;

            er += txtName.txtValidate();

            if (er == 0)
            {
                gr.Name = txtName.txtTextValue;
                gr.Description = txtDescription.txtTextValue;

                if (gr.Insert())
                {
                    MessageBox.Show("Group Inserted !!");
                    txtName.txtTextValue = "";
                    txtDescription.txtTextValue = "";
                    txtName.Focus();
                }
                else
                {
                    MessageBox.Show(gr.Error);
                }
            }
        }
    }
}
