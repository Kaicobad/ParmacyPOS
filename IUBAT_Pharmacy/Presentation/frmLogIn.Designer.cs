namespace IUBAT_Pharmacy.Presentation
{
    partial class frmLogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cmbName = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.txtType = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            resources.ApplyResources(this.btnLogIn, "btnLogIn");
            this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnLogIn.FlatAppearance.BorderSize = 2;
            this.btnLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.UseCompatibleTextRendering = true;
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // cmbName
            // 
            resources.ApplyResources(this.cmbName, "cmbName");
            this.cmbName.Name = "cmbName";
            this.cmbName.txtComboText = "";
            this.cmbName.txtRequired = false;
            this.cmbName.txtTextLabel = "Your Name";
            this.cmbName.txtTextValueDouble = 0D;
            this.cmbName.txtTextValueInt = 0;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
            // 
            // txtType
            // 
            resources.ApplyResources(this.txtType, "txtType");
            this.txtType.MultiLine = false;
            this.txtType.Name = "txtType";
            this.txtType.txtDoubleValue = 0D;
            this.txtType.txtFloatValue = 0F;
            this.txtType.txtIntValue = 0;
            this.txtType.txtRequired = true;
            this.txtType.txtTextLabel = "Type Of User";
            this.txtType.txtTextValue = "";
            this.txtType.TxtType = TextType.Text;
            // 
            // frmLogIn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtType);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogIn";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.ucText txtType;
        private System.Windows.Forms.Button btnLogIn;
        private MyControls.ucCombo cmbName;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
    }
}