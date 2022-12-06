using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmRackNew : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        public frmRackNew()
        {
            InitializeComponent();
        }

        private void frmRackNew_Load(object sender, EventArgs e)
        {
            DAL.clsProduct p = new DAL.clsProduct();
            cmbProduct.setDataSource(p.Select());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAL.clsRack rc = new DAL.clsRack();

            int er = 0;
            er += txtName.txtValidate();
            er += cmbProduct.txtValidate();

            if(er == 0)
            {
                rc.Name = txtName.txtTextValue;
                rc.ProductId = cmbProduct.txtTextValueInt;

                if (rc.Insert())
                {
                    MessageBox.Show("Added new Item's On Rack");
                    txtName.txtTextValue = "";
                    cmbProduct.txtTextValueInt = -1;
                }
                else
                {
                    MessageBox.Show(rc.Error);
                }
            }
        }
    }
}
