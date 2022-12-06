using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmCategoryNew : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        public frmCategoryNew()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAL.clsCategory ctg = new DAL.clsCategory();

            int er = 0;
            er += txtName.txtValidate();

            if (er == 0)
            {
                ctg.Name = txtName.txtTextValue;

                if (ctg.Insert())
                {
                    MessageBox.Show("New Category Inserted !!");
                    txtName.txtTextValue = "";
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
