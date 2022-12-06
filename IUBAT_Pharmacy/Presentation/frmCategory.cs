using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmCategory : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsCategory ctg = new DAL.clsCategory();
            dgvData.DataSource = ctg.Select().Tables[0];
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmCategoryNew().ShowDialog();
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

            DAL.clsCategory ctg = new DAL.clsCategory();
            ctg.Id = Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value);

            if (ctg.Delete())
            {
                MessageBox.Show("Category Deleted");
                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show(ctg.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count <= 0)
            {
                return;
            }

            new frmCategoryEdit(Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value)).ShowDialog();
            btnSearch.PerformClick();
        }
    }
}
