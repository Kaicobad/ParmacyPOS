using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmPower : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmPower()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsPower pr = new DAL.clsPower();
            pr.Name = txtSearch.Text;
            dgvData.DataSource = pr.Select().Tables[0];
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmPowerNew().ShowDialog();
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

            DAL.clsPower pr = new DAL.clsPower();
            pr.Id = Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value);

            if (pr.Delete())
            {
                MessageBox.Show("Power Info Deleted ");
                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show(pr.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count <= 0)
                return;

            new frmPowerEdit(Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value)).ShowDialog();
            btnSearch.PerformClick();
        }
    }
}
