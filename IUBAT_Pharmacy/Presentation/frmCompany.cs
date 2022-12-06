using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmCompany : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmCompany()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmCompanyNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsCompany cp = new DAL.clsCompany();
            cp.Name = txtSearch.Text;
            dgvData.DataSource = cp.Select().Tables[0];
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

            DAL.clsCompany cmp = new DAL.clsCompany();
            cmp.Id = Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value);

            if (cmp.Delete())
            {
                MessageBox.Show("Company Deleted");
                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show(cmp.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count <= 0)
                return;
            
            new frmCompanyEdit(Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value)).ShowDialog();
            btnSearch.PerformClick();
        }

        
    }
}
