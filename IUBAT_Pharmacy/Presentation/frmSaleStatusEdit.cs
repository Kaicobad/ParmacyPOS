using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmSaleStatusEdit : IUBAT_Pharmacy.Presentation.Common.frmNew
    {

        DAL.clsSaleStatus st = new DAL.clsSaleStatus();
        public frmSaleStatusEdit(int id)
        {
            InitializeComponent();

            st.Id = id;
            if (st.SelectById())
            {
                txtName.txtTextValue = st.Name;
                txtDescription.txtTextValue = st.Description;
            }
            else
            {
                MessageBox.Show(st.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            int er = 0;
            er += txtName.txtValidate();

            if (er == 0)
            {
                st.Name = txtName.txtTextValue;
                st.Description = txtDescription.txtTextValue;

                if (st.Update())
                {
                    MessageBox.Show("User Defined Sale Status Updated !!");
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
