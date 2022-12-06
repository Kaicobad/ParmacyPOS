using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmPaymentMethod : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmPaymentMethod()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsPaymentMethod pm = new DAL.clsPaymentMethod();
            dgvData.DataSource = pm.Select().Tables[0];
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmPaymentMethodNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvData.SelectedRows.Count <= 0)
            {
                return;
            }

            DialogResult dr = MessageBox.Show("Delete Confimation", "Are You Sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr != System.Windows.Forms.DialogResult.Yes)
                return;

            DAL.clsPaymentMethod pm = new DAL.clsPaymentMethod();
            pm.Id = Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value);

            if (pm.Delete())
            {
                MessageBox.Show("Pamyment Method Removed");
                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show(pm.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count <= 0)
                return;

            new frmPaymentMethodEdit(Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value)).ShowDialog();
            btnSearch.PerformClick();
        }
    }
}
