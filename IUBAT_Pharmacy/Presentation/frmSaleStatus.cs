using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmSaleStatus : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmSaleStatus()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmSaleStatusNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsSaleStatus st = new DAL.clsSaleStatus();
            dgvData.DataSource = st.Select().Tables[0];
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

            DAL.clsSaleStatus st = new DAL.clsSaleStatus();
            st.Id = Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value);

            if (st.Delete())
            {
                MessageBox.Show("Power Info Deleted ");
                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show(st.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count <= 0)
                return;

            new frmSaleStatusEdit(Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value)).ShowDialog();
            btnSearch.PerformClick();
        }
    }
}
