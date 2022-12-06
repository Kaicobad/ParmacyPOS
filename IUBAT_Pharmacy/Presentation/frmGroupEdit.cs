using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmGroupEdit : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
       DAL.clsGroup gr = new DAL.clsGroup();
        public frmGroupEdit(int id)
        {
            InitializeComponent();

            gr.Id = id;

            if (gr.SelectById())
	        {
		        txtName.txtTextValue = gr.Name;
                txtDescription.txtTextValue = gr.Description;
	        }
            else
	            {
                    MessageBox.Show(gr.Error);
                    this.Close();
	            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int er = 0;

            er += txtName.txtValidate();

            if (er == 0)
            {
                gr.Name = txtName.txtTextValue;
                gr.Description = txtDescription.txtTextValue;

                if (gr.Update())
                {
                    MessageBox.Show("Group Updated !!");
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
