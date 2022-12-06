using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmEmployeeEdit : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        DAL.clsEmployee em = new DAL.clsEmployee();
        public frmEmployeeEdit(int id)
        {
            InitializeComponent();
            em.Id = id;
            if (em.SelectById())
            {
                txtName.txtTextValue = em.Name;
                txtPhone.txtTextValue = em.Phone;
                txtEmail.txtTextValue = em.Email;
                txtType.txtTextValue = em.Type;
                txtPassword.txtTextValue = em.Password;
                em.Image = FileImage.ImageToByte(pbImage.BGImage);
            }
            else
            {
                MessageBox.Show(em.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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

                if (em.Update())
                {
                    MessageBox.Show("Employee Information is Updated !!");
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
