using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmRack : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmRack()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsRack rc = new DAL.clsRack();

            dgvData.DataSource = rc.Select().Tables[0];
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmRackNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void frmRack_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count <= 0)
                return;

            new frmRackEdit(Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value)).ShowDialog();
            btnSearch.PerformClick();
        }
    }
}
