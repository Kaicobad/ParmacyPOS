namespace IUBAT_Pharmacy.Presentation
{
    partial class frmPaymentMethodEdit
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
            this.txtCompany = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.TxtName = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(336, 146);
            this.btnExit.Size = new System.Drawing.Size(87, 27);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(15, 146);
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCompany
            // 
            this.txtCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompany.AutoSize = true;
            this.txtCompany.Location = new System.Drawing.Point(15, 73);
            this.txtCompany.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtCompany.MultiLine = false;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(410, 40);
            this.txtCompany.TabIndex = 5;
            this.txtCompany.txtDoubleValue = 0D;
            this.txtCompany.txtFloatValue = 0F;
            this.txtCompany.txtIntValue = 0;
            this.txtCompany.txtRequired = false;
            this.txtCompany.txtTextLabel = "Company";
            this.txtCompany.txtTextValue = "";
            this.txtCompany.TxtType = TextType.Text;
            // 
            // TxtName
            // 
            this.TxtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtName.AutoSize = true;
            this.TxtName.Location = new System.Drawing.Point(16, 25);
            this.TxtName.MinimumSize = new System.Drawing.Size(233, 40);
            this.TxtName.MultiLine = false;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(409, 40);
            this.TxtName.TabIndex = 4;
            this.TxtName.txtDoubleValue = 0D;
            this.TxtName.txtFloatValue = 0F;
            this.TxtName.txtIntValue = 0;
            this.TxtName.txtRequired = true;
            this.TxtName.txtTextLabel = "Name";
            this.TxtName.txtTextValue = "";
            this.TxtName.TxtType = TextType.Text;
            // 
            // frmPaymentMethodEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(437, 186);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.TxtName);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmPaymentMethodEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDIT PAYMENT METHOD";
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.TxtName, 0);
            this.Controls.SetChildIndex(this.txtCompany, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MyControls.ucText txtCompany;
        public MyControls.ucText TxtName;
    }
}
