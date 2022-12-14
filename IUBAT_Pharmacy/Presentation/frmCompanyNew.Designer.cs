namespace IUBAT_Pharmacy.Presentation
{
    partial class frmCompanyNew
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
            this.txtName = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtContactPerson = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtContact = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtEmail = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtAddress = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.dptDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(314, 392);
            this.btnExit.Size = new System.Drawing.Size(95, 27);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(6, 392);
            this.btnSave.Size = new System.Drawing.Size(89, 27);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(6, 18);
            this.txtName.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtName.MultiLine = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(402, 40);
            this.txtName.TabIndex = 2;
            this.txtName.txtDoubleValue = 0D;
            this.txtName.txtFloatValue = 0F;
            this.txtName.txtIntValue = 0;
            this.txtName.txtRequired = true;
            this.txtName.txtTextLabel = "Name";
            this.txtName.txtTextValue = "";
            this.txtName.TxtType = TextType.Text;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContactPerson.AutoSize = true;
            this.txtContactPerson.Location = new System.Drawing.Point(6, 80);
            this.txtContactPerson.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtContactPerson.MultiLine = false;
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(402, 40);
            this.txtContactPerson.TabIndex = 3;
            this.txtContactPerson.txtDoubleValue = 0D;
            this.txtContactPerson.txtFloatValue = 0F;
            this.txtContactPerson.txtIntValue = 0;
            this.txtContactPerson.txtRequired = false;
            this.txtContactPerson.txtTextLabel = "Contact Person";
            this.txtContactPerson.txtTextValue = "";
            this.txtContactPerson.TxtType = TextType.Text;
            // 
            // txtContact
            // 
            this.txtContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact.AutoSize = true;
            this.txtContact.Location = new System.Drawing.Point(6, 135);
            this.txtContact.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtContact.MultiLine = false;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(402, 40);
            this.txtContact.TabIndex = 4;
            this.txtContact.txtDoubleValue = 0D;
            this.txtContact.txtFloatValue = 0F;
            this.txtContact.txtIntValue = 0;
            this.txtContact.txtRequired = true;
            this.txtContact.txtTextLabel = "Contact";
            this.txtContact.txtTextValue = "";
            this.txtContact.TxtType = TextType.Text;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(6, 201);
            this.txtEmail.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtEmail.MultiLine = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(402, 40);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.txtDoubleValue = 0D;
            this.txtEmail.txtFloatValue = 0F;
            this.txtEmail.txtIntValue = 0;
            this.txtEmail.txtRequired = true;
            this.txtEmail.txtTextLabel = "Email";
            this.txtEmail.txtTextValue = "";
            this.txtEmail.TxtType = TextType.Text;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.AutoSize = true;
            this.txtAddress.Location = new System.Drawing.Point(6, 270);
            this.txtAddress.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtAddress.MultiLine = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(402, 40);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.txtDoubleValue = 0D;
            this.txtAddress.txtFloatValue = 0F;
            this.txtAddress.txtIntValue = 0;
            this.txtAddress.txtRequired = true;
            this.txtAddress.txtTextLabel = "Address";
            this.txtAddress.txtTextValue = "";
            this.txtAddress.TxtType = TextType.Text;
            // 
            // dptDateTime
            // 
            this.dptDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dptDateTime.CustomFormat = "mm-dd-yyyy";
            this.dptDateTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dptDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptDateTime.Location = new System.Drawing.Point(6, 352);
            this.dptDateTime.Name = "dptDateTime";
            this.dptDateTime.Size = new System.Drawing.Size(402, 21);
            this.dptDateTime.TabIndex = 7;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(3, 334);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(66, 15);
            this.lblDateTime.TabIndex = 8;
            this.lblDateTime.Text = "Date & Time";
            // 
            // frmCompanyNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(414, 432);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.dptDateTime);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtContactPerson);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmCompanyNew";
            this.Text = "ADD NEW COMPANY INFORMATION";
            this.Load += new System.EventHandler(this.frmCompanyNew_Load);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtContactPerson, 0);
            this.Controls.SetChildIndex(this.txtContact, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtAddress, 0);
            this.Controls.SetChildIndex(this.dptDateTime, 0);
            this.Controls.SetChildIndex(this.lblDateTime, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.ucText txtName;
        private MyControls.ucText txtContactPerson;
        private MyControls.ucText txtContact;
        private MyControls.ucText txtEmail;
        private MyControls.ucText txtAddress;
        private System.Windows.Forms.DateTimePicker dptDateTime;
        private System.Windows.Forms.Label lblDateTime;
    }
}
