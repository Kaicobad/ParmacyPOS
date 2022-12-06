using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmDiscount : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmDiscount()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmDiscountNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsDiscount ds = new DAL.clsDiscount();
            dgvData.DataSource = ds.Select().Tables[0];
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

            DAL.clsDiscount ds = new DAL.clsDiscount();
            ds.Id = Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value);

            if (ds.Delete())
            {
                MessageBox.Show("Discount Deleted");
                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show(ds.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count <= 0)
                return;

            new frmDiscountEdit(Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value)).ShowDialog();
            btnSearch.PerformClick();
        }
    }
}
