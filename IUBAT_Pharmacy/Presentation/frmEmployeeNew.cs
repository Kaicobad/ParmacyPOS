using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmEmployeeNew : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        public frmEmployeeNew()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAL.clsEmployee em = new DAL.clsEmployee();

            int er = 0;
            er += txtName.txtValidate();
            er += txtPhone.txtValidate();
            er += txtEmail.txtValidate();
            er += txtType.txtValidate();
            er += txtPassword.txtValidate();
            er += pbImage.txtValidate();

            if (er == 0)
            {
                em.Name = txtName.txtTextValue;
                em.Phone = txtPhone.txtTextValue;
                em.Email = txtEmail.txtTextValue;
                em.Type = txtType.txtTextValue;
                em.Password = txtPassword.txtTextValue;
                em.Image = FileImage.ImageToByte(pbImage.BGImage);

                if (em.Insert())
                {
                    MessageBox.Show("Employee Information is Saved !!");
                    txtName.txtTextValue = "";
                    txtPhone.txtTextValue = "";
                    txtEmail.txtTextValue = "";
                    txtType.txtTextValue = "";
                    txtPassword.txtTextValue = "";
                    pbImage.BGImage = null;
                    txtName.Focus();
                }
                else
                {
                    MessageBox.Show(em.Error);
                }
            }
        }
    }
}
