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

namespace IUBAT_Pharmacy
{
    public partial class frmBackUp : Form
    {

        SqlConnection con = new SqlConnection(IUBAT_Pharmacy.Properties.Settings.Default.Connection);

        public frmBackUp()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtbackup.Text = fbd.SelectedPath;
                btnbackup.Enabled = true;
            }
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            string db = con.Database.ToString();
            try
            {
                if (txtbackup.Text == string.Empty)
                {
                    MessageBox.Show("Please Select Location");
                }

                else
                {
                    string cmd = "BACKUP DATABASE [" + db + "] TO DISK='" + txtbackup.Text + "\\" + "Database" + "-" + DateTime.Now.ToString("dd-MM-yyyy--HH-mm-ss") + ".bak'";

                    using (SqlCommand command = new SqlCommand(cmd, con))
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Database Backup Done Successefully");
                        btnbackup.Enabled = false;
                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

    }
}

