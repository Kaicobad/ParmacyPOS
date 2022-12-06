using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmCompanyEdit : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        DAL.clsCompany cp = new DAL.clsCompany();
        public frmCompanyEdit(int id)
        {
            InitializeComponent();

            cp.Id = id;
            if (cp.SelectById())
            {
                txtName.txtTextValue = cp.Name;
                txtContactPerson.txtTextValue = cp.ContactPerson;
                txtContact.txtTextValue = cp.Contact;
                txtEmail.txtTextValue = cp.Email;
                txtAddress.txtTextValue = cp.Address;
                dptDateTime.Value = cp.CreateDateTime;
            }
            else
            {
                MessageBox.Show(cp.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            int er = 0;
            er += txtName.txtValidate();
            er += txtContactPerson.txtValidate();
            er += txtContact.txtValidate();
            er += txtAddress.txtValidate();
            er += txtEmail.txtValidate();
            if (er == 0)
            {
                cp.Name = txtName.txtTextValue;
                cp.ContactPerson = txtContactPerson.txtTextValue;
                cp.Contact = txtContact.txtTextValue;
                cp.Email = txtEmail.txtTextValue;
                cp.Address = txtAddress.txtTextValue;
                cp.CreateDateTime = dptDateTime.Value;

                if (cp.Update())
                {
                    MessageBox.Show("Company Information Is Modified!!");
                    txtName.Focus();
                }
                else
                {
                    MessageBox.Show(cp.Error);
                }
            }
        }
    }
}
