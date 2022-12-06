using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmGroup : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmGroup()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsGroup gr = new DAL.clsGroup();
            gr.Name = txtSearch.Text;
            dgvData.DataSource = gr.Select().Tables[0];
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmGroupNew().ShowDialog();
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

            DAL.clsGroup gr = new DAL.clsGroup();
            gr.Id = Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value);

            if (gr.Delete())
            {
                MessageBox.Show("Group Deleted");
                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show(gr.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count <= 0)
                return;

            new frmGroupEdit(Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value)).ShowDialog();
            btnSearch.PerformClick();
        }
    }
}
