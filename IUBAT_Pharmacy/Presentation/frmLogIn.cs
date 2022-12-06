using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmLogIn : Form
    {
        public static int logid { get; set; }
        public static string loguname { get; set; }
        public static string logutype { get; set; }
        public static string logpass { get; set; }// added by me

        DAL.clsEmployee em = new DAL.clsEmployee();
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            cmbName.setDataSource(em.Select());
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            em.Id = cmbName.txtTextValueInt;
            em.Name = cmbName.txtComboText;
            em.Password = txtPassword.Text;
            em.Type = txtType.txtTextValue;
            if(em.Login()) 
            {
                logid = em.Id;
                loguname = em.Name;
                logutype = em.Type;
                logpass = em.Password;
                frmMain fm = new frmMain();
                this.Hide();
                fm.Show();
            }
            else
            {
                MessageBox.Show("Please Correct the password !!");
            }
                
        }

        void gr_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain fm = new frmMain();
            fm.Close();
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            em.Id = cmbName.txtTextValueInt;
            em.SelectById();

            txtType.txtTextValue = em.Type;
        }
      
    }
}
