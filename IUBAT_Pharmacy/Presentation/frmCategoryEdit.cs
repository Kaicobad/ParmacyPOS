using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmCategoryEdit : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        DAL.clsCategory ctg = new DAL.clsCategory();
        public frmCategoryEdit(int id)
        {
            InitializeComponent();

            ctg.Id = id;
            if (ctg.SelectById())
            {
                txtName.txtTextValue = ctg.Name;
            }
            else
            {
                MessageBox.Show(ctg.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int er = 0;
            er += txtName.txtValidate();

            if (er == 0)
            {
                ctg.Name = txtName.txtTextValue;

                if (ctg.Update())
                {
                    MessageBox.Show("Category Modified !!");
                    txtName.Focus();
                }
                else
                {
                    MessageBox.Show(ctg.Error);
                }
            }
        }
    }
}

