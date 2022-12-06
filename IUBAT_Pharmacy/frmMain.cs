using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUBAT_Pharmacy
{
    public partial class frmMain : Form
    {
        Presentation.frmGroup gr = new Presentation.frmGroup();
        Presentation.frmPower pr = new Presentation.frmPower();
        Presentation.frmCompany cp = new Presentation.frmCompany();
        Presentation.frmCategory ctg = new Presentation.frmCategory();
        Presentation.frmUnit u = new Presentation.frmUnit();
        Presentation.frmDiscount ds = new Presentation.frmDiscount();
        Presentation.frmSaleStatus st = new Presentation.frmSaleStatus();
        Presentation.frmProduct prd = new Presentation.frmProduct();
        Presentation.frmRack rc = new Presentation.frmRack();
        
        Presentation.frmPaymentMethod pm = new Presentation.frmPaymentMethod();
        Presentation.frmPurchase prch = new Presentation.frmPurchase();
        Presentation.frmSale sl = new Presentation.frmSale();

        public frmMain()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prd.Show();
            prd.MdiParent = this;
            prd.BringToFront();
            if (prd.IsDisposed)
            {
                prd = new Presentation.frmProduct();
            }
        }

        private void categoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ctg.Show();
            ctg.MdiParent = this;
            ctg.BringToFront();
            if (ctg.IsDisposed)
            {
                ctg = new Presentation.frmCategory();
            }
        }

        private void tNowTime_Tick(object sender, EventArgs e)
        {
            lblWatch2.Text = "Date and Time :    " + DateTime.Now.ToString() + "                                         © CopyRight Protected By @Kaicobad Hassan";
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gr.Show();
            gr.MdiParent = this;
            gr.BringToFront();
            if (gr.IsDisposed)
            {
                gr = new Presentation.frmGroup();
            }
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void powerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pr.Show();
            pr.MdiParent = this;
            pr.BringToFront();
            if (pr.IsDisposed)
            {
                pr = new Presentation.frmPower();
            }
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cp.IsDisposed)
            {
                cp = new Presentation.frmCompany();
            }
            cp.Show();
            cp.MdiParent = this;
            cp.BringToFront();
            
        }

        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            u.Show();
            u.MdiParent = this;
            u.BringToFront();
            if (u.IsDisposed)
            {
                u = new Presentation.frmUnit();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ds.Show();
            ds.MdiParent = this;
            ds.BringToFront();
            if (ds.IsDisposed)
            {
                ds = new Presentation.frmDiscount();
            }
        }

        private void SaleStatus_toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            st.Show();
            st.MdiParent = this;
            st.BringToFront();
            if (st.IsDisposed)
            {
                st = new Presentation.frmSaleStatus();
            }
        }

        private void rackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rc.Show();
            rc.MdiParent = this;
            rc.BringToFront();
            if (rc.IsDisposed)
            {
                rc = new Presentation.frmRack();
            }
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentation.frmEmployee emp = new Presentation.frmEmployee();
            emp.Show();
            emp.MdiParent = this;
            emp.BringToFront();
            if (emp.IsDisposed)
            
                emp = new Presentation.frmEmployee();
            
        }

        private void paymentMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pm.Show();
            pm.MdiParent = this;
            pm.BringToFront();
            if (pm.IsDisposed)
            {
                pm = new Presentation.frmPaymentMethod();
            }
        }

        private void purchaseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            prch.Show();
            
            if (prch.IsDisposed)
            {
                prch = new Presentation.frmPurchase();
            }
            prch.MdiParent = this;
            prch.BringToFront();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            if (sl.IsDisposed)
            {
                sl = new Presentation.frmSale();
            }

            sl.Show();
            sl.MdiParent = this;
            sl.BringToFront();
        }

        private void tsBtnLogin_Click(object sender, EventArgs e)
        {

            this.Close();

            Presentation.frmLogIn ln = new Presentation.frmLogIn();
            ln.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = Presentation.frmLogIn.loguname;
            lblType.Text = "LogedIn As :" + Presentation.frmLogIn.logutype;
            

            frmMain fm = new frmMain();

            if (Presentation.frmLogIn.logutype == "USER")
            {
                lblType.ForeColor = Color.Red;
                mnuStrip.Enabled = false;
            }
            else
            {
                lblType.ForeColor = Color.Green;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Presentation.frmSaleDetailsNew sd = new Presentation.frmSaleDetailsNew();
            sd.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Presentation.frmPurchaseNew pn = new Presentation.frmPurchaseNew();

            pn.ShowDialog();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackUp fmb = new frmBackUp();
            fmb.MdiParent = this;
            fmb.Show();
            if (fmb.IsDisposed)
            {
                fmb = new frmBackUp();
            }
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRestore fmr = new frmRestore();
            fmr.MdiParent = this;
            fmr.Show();
            if (fmr.IsDisposed)
            {
                fmr = new frmRestore();
            }
        }

        private void showProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentation.frmProductStatistics prs = new Presentation.frmProductStatistics();
            prs.MdiParent = this;
            prs.Show();

            if (prs.IsDisposed)
            {
                prs = new Presentation.frmProductStatistics();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Presentation.frmPurchase prch = new Presentation.frmPurchase();
            prch.MdiParent = this;
            prch.Show();
            if (prch.IsDisposed)
            {
                prch = new Presentation.frmPurchase();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Presentation.frmSale sal = new Presentation.frmSale();
            sal.MdiParent = this;
            sal.Show();
            if (sal.IsDisposed)
            {
                sal = new Presentation.frmSale();
            }
        }
      

    }
}
