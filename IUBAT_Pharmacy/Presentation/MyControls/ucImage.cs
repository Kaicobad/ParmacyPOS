using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation.MyControls
{
    public partial class ucImage : UserControl
    {

        public bool txtRequired { get; set; }

        public string txtLabel
        {
            get
            {
                return lblLabel.Text;
            }
            set
            {
                lblLabel.Text = value; 
            }
        }

        public Image BGImage {
            get
            {
                return pbImage.BackgroundImage;
            }
            set
            {
                pbImage.BackgroundImage = value;
            }
        }

        public int txtValidate()
        {
            lblError.Text = "";
            if (txtRequired && pbImage.BackgroundImage == null)
                return 1;
            return 0;
        }

        public ucImage()
        {
            InitializeComponent();
        }

        private void llBrowse_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "JPEG|*.jpg|GIF|*.gif|PNG|*.png";

            ofd.ShowDialog();

            if (ofd.FileName == null || ofd.FileName == "")
                return;

            pbImage.BackgroundImage = Image.FromFile(ofd.FileName);
        }

        private void llClear_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.BackgroundImage = null;
        }
    }
}
