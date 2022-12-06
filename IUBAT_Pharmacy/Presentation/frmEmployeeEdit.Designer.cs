namespace IUBAT_Pharmacy.Presentation
{
    partial class frmEmployeeEdit
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
            this.txtType = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtPassword = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtEmail = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtPhone = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtName = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.pbImage = new IUBAT_Pharmacy.Presentation.MyControls.ucImage();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(283, 323);
            this.btnExit.Size = new System.Drawing.Size(89, 27);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(8, 324);
            this.btnSave.Size = new System.Drawing.Size(93, 25);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtType
            // 
            this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtType.AutoSize = true;
            this.txtType.Location = new System.Drawing.Point(8, 199);
            this.txtType.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtType.MultiLine = false;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(364, 40);
            this.txtType.TabIndex = 9;
            this.txtType.txtDoubleValue = 0D;
            this.txtType.txtFloatValue = 0F;
            this.txtType.txtIntValue = 0;
            this.txtType.txtRequired = true;
            this.txtType.txtTextLabel = "Type Of Employee";
            this.txtType.txtTextValue = "";
            this.txtType.TxtType = TextType.Text;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPassword.AutoSize = true;
            this.txtPassword.Location = new System.Drawing.Point(8, 261);
            this.txtPassword.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtPassword.MultiLine = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(364, 40);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.txtDoubleValue = 0D;
            this.txtPassword.txtFloatValue = 0F;
            this.txtPassword.txtIntValue = 0;
            this.txtPassword.txtRequired = true;
            this.txtPassword.txtTextLabel = "Password";
            this.txtPassword.txtTextValue = "";
            this.txtPassword.TxtType = TextType.Text;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(8, 133);
            this.txtEmail.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtEmail.MultiLine = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(364, 40);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.txtDoubleValue = 0D;
            this.txtEmail.txtFloatValue = 0F;
            this.txtEmail.txtIntValue = 0;
            this.txtEmail.txtRequired = false;
            this.txtEmail.txtTextLabel = "Email";
            this.txtEmail.txtTextValue = "";
            this.txtEmail.TxtType = TextType.Text;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPhone.AutoSize = true;
            this.txtPhone.Location = new System.Drawing.Point(8, 74);
            this.txtPhone.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtPhone.MultiLine = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(364, 40);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.txtDoubleValue = 0D;
            this.txtPhone.txtFloatValue = 0F;
            this.txtPhone.txtIntValue = 0;
            this.txtPhone.txtRequired = true;
            this.txtPhone.txtTextLabel = "Phone";
            this.txtPhone.txtTextValue = "";
            this.txtPhone.TxtType = TextType.Text;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(8, 12);
            this.txtName.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtName.MultiLine = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(364, 40);
            this.txtName.TabIndex = 6;
            this.txtName.txtDoubleValue = 0D;
            this.txtName.txtFloatValue = 0F;
            this.txtName.txtIntValue = 0;
            this.txtName.txtRequired = true;
            this.txtName.txtTextLabel = "Name";
            this.txtName.txtTextValue = "";
            this.txtName.TxtType = TextType.Text;
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.BGImage = null;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(383, 12);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(368, 348);
            this.pbImage.TabIndex = 11;
            this.pbImage.txtLabel = "Image";
            this.pbImage.txtRequired = false;
            // 
            // frmEmployeeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 362);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmEmployeeEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDIT EMPLOYEE INFORMATION";
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtPhone, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.txtType, 0);
            this.Controls.SetChildIndex(this.pbImage, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.ucText txtType;
        private MyControls.ucText txtPassword;
        private MyControls.ucText txtEmail;
        private MyControls.ucText txtPhone;
        private MyControls.ucText txtName;
        private MyControls.ucImage pbImage;
    }
}
