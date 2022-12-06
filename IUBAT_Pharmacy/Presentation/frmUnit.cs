using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmUnit : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmUnit()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmUnitNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsUnit u = new DAL.clsUnit();
            dgvData.DataSource = u.Select().Tables[0];
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

            DAL.clsUnit ut = new DAL.clsUnit();
            ut.Id = Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value);

            if (ut.Delete())
            {
                MessageBox.Show("Unit Info Deleted ");
                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show(ut.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count <= 0)
                return;

            new frmUnitEdit(Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value)).ShowDialog();
            btnSearch.PerformClick();


        }
    }
}
