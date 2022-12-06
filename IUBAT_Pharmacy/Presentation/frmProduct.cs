using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmProduct : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        DAL.clsProduct p = new DAL.clsProduct();
        public frmProduct()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmProductEdit().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsProduct p = new DAL.clsProduct();
            dgvData.DataSource = p.Select().Tables[0];
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            LoadReport("rptProduct", "Product Report", (DataTable)dgvData.DataSource);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count <= 0)
            {
                return;
            }

            DialogResult dr = MessageBox.Show("Delete Confimation", "Are You Sure?", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);

            if (dr != System.Windows.Forms.DialogResult.Yes)
                return;

            DAL.clsProduct pd = new DAL.clsProduct();
            pd.Id = Convert.ToInt32(dgvData.SelectedRows[0].Cells["colId"].Value);

            if (pd.Delete())
            {
                MessageBox.Show("Product Deleted");
                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show(p.Error);
            }
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ////if (dgvData.SelectedRows.Count <= 0)
            ////    return;

            ////new frmProductEdit(dgvData.SelectedRows[0].Cells["colId"].Value);
            //btnSearch.PerformClick();
        }
    }
}
