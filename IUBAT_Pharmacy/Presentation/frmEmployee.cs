using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmEmployee : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsEmployee em = new DAL.clsEmployee();
            dgvData.DataSource = em.Select().Tables[0];
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmEmployeeNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            LoadReport("rptEmployee", "Employee Report", (DataTable)dgvData.DataSource);
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

            DAL.clsEmployee em = new DAL.clsEmployee();
            em.Id = Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value);

            if (em.Delete())
            {
                MessageBox.Show("Employee Deleted");
                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show(em.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count <= 0)
                return;

            new frmEmployeeEdit(Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value)).ShowDialog();
            btnSearch.PerformClick();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
