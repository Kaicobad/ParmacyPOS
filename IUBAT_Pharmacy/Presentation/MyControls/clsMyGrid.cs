using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT_Pharmacy.Presentation.MyControls
{
    class clsMyGrid:System.Windows.Forms.DataGridView
    {
        public clsMyGrid():base()
        {
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BackgroundColor = System.Drawing.Color.White;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Location = new System.Drawing.Point(12, 35);
            this.Name = "dgvData";
            this.ReadOnly = true;
            this.Size = new System.Drawing.Size(568, 326);
            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

        }
    }
}
