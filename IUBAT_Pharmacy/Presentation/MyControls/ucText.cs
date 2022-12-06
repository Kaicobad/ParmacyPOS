using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;

namespace IUBAT_Pharmacy.Presentation.MyControls
{
    public partial class ucText : UserControl
    {

        public TextType TxtType { get; set; }

        public bool txtRequired { get; set; }
       

       

        public bool MultiLine {
            get { return txtText.Multiline; }
            set { txtText.Multiline = value; }
        }

        public string txtTextLabel
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


        public string txtTextValue
        {
            get
            {
                return txtText.Text;
            }
            set
            {
                txtText.Text = value;
            }
        }

        public int txtIntValue //text validation for Integer type value
        {
            get
            {
                try
                {
                    return Convert.ToInt32(txtText.Text);
                }
                catch
                {
                    return 0;
                }
            }
            set
            {
                txtText.Text = value.ToString();
            }
        }


        public float txtFloatValue //text validation for float type value
        {
            get
            {
                try
                {
                    return (float)Convert.ToDouble(txtText.Text);
                }
                catch
                {
                    return 0;
                }
            }
            set
            {
                txtText.Text = value.ToString();
            }
        }

        public double txtDoubleValue //text validation for double type value
        {
            get
            {
                try
                {
                    return Convert.ToDouble(txtText.Text);
                }
                catch
                {
                    return 0;
                }
            }
            set
            {
                txtText.Text = value.ToString();
            }
        }

        //public decimal txtPersentValue //text validation for persent type value
        //{
        //    get
        //    {
        //        try
        //        {
        //            return Decimal.TryParse(txtText.Text. out);
        //        }
        //        catch
        //        {
        //            return 0;
        //        }
        //    }
        //    set
        //    {
        //        txtText.Text = value.ToString();
        //    }
        //}

        public int txtValidate()
        {
            lblError.Text = "";
            if(txtRequired && txtText.Text == "")
            {
                lblError.Text = "Required !!";
                return 1;
            }
            return 0;
        }


        public ucText()
        {
            InitializeComponent();
        }

        private void ucText_Load(object sender, EventArgs e)
        {
            if (TxtType == TextType.Integer || TxtType == TextType.Float)
            {
                txtText.KeyPress += txtText_KeyPress;
            }
        }

        void txtText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtType == TextType.Integer)
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
            else if (TxtType == TextType.Float || TxtType == TextType.Double)
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.'))
                {
                    e.Handled = true;
                }
            }

          
            //else if (TxtType == TextType.Persent)
            //{
            //    if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.'))
            //    {
            //        e.Handled = true;
            //    }
            //}

            
        }
    }
}
