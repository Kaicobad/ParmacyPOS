using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmProductStatistics : Form
    {
        DAL.clsPurchaseDetails prc = new DAL.clsPurchaseDetails();

        public frmProductStatistics()
        {
            InitializeComponent();
        }

        private void frmProductStatistics_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = prc.SelectInventorys().Tables[0];
            
        }
    }
}
