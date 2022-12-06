using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmCompanyNew : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        public frmCompanyNew()
        {
            InitializeComponent();
        }

        private void frmCompanyNew_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAL.clsCompany cp = new DAL.clsCompany();
            int er = 0;
            er += txtName.txtValidate();
            er += txtContactPerson.txtValidate();
            er += txtContact.txtValidate();
            er += txtAddress.txtValidate();
            if (er == 0)
            {
                cp.Name = txtName.txtTextValue;
                cp.ContactPerson = txtContactPerson.txtTextValue;
                cp.Contact = txtContact.txtTextValue;
                cp.Email = txtEmail.txtTextValue;
                cp.Address = txtAddress.txtTextValue;
                cp.CreateDateTime = dptDateTime.Value;

                if (cp.Insert())
                {
                        MessageBox.Show("Company Is registered!!");
                        txtName.txtTextValue = "";
                        txtContactPerson.txtTextValue = "";
                        txtContact.txtTextValue = "";
                        txtEmail.txtTextValue = "";
                        txtAddress.txtTextValue = "";

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
