namespace IUBAT_Pharmacy.Presentation
{
    partial class frmUnitEdit
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
            this.txtPrimaryQty = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtDescription = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtName = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(236, 180);
            this.btnExit.Size = new System.Drawing.Size(87, 27);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 180);
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPrimaryQty
            // 
            this.txtPrimaryQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrimaryQty.AutoSize = true;
            this.txtPrimaryQty.Location = new System.Drawing.Point(15, 117);
            this.txtPrimaryQty.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtPrimaryQty.MultiLine = false;
            this.txtPrimaryQty.Name = "txtPrimaryQty";
            this.txtPrimaryQty.Size = new System.Drawing.Size(308, 40);
            this.txtPrimaryQty.TabIndex = 7;
            this.txtPrimaryQty.txtDoubleValue = 0D;
            this.txtPrimaryQty.txtFloatValue = 0F;
            this.txtPrimaryQty.txtIntValue = 0;
            this.txtPrimaryQty.txtRequired = true;
            this.txtPrimaryQty.txtTextLabel = "PrimaryQty";
            this.txtPrimaryQty.txtTextValue = "";
            this.txtPrimaryQty.TxtType = TextType.Text;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.AutoSize = true;
            this.txtDescription.Location = new System.Drawing.Point(15, 64);
            this.txtDescription.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtDescription.MultiLine = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(308, 40);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.txtDoubleValue = 0D;
            this.txtDescription.txtFloatValue = 0F;
            this.txtDescription.txtIntValue = 0;
            this.txtDescription.txtRequired = true;
            this.txtDescription.txtTextLabel = "Description";
            this.txtDescription.txtTextValue = "";
            this.txtDescription.TxtType = TextType.Text;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(15, 12);
            this.txtName.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtName.MultiLine = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(308, 40);
            this.txtName.TabIndex = 5;
            this.txtName.txtDoubleValue = 0D;
            this.txtName.txtFloatValue = 0F;
            this.txtName.txtIntValue = 0;
            this.txtName.txtRequired = true;
            this.txtName.txtTextLabel = "Name";
            this.txtName.txtTextValue = "";
            this.txtName.TxtType = TextType.Text;
            // 
            // frmUnitEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(337, 220);
            this.Controls.Add(this.txtPrimaryQty);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmUnitEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit Edit form";
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            this.Controls.SetChildIndex(this.txtPrimaryQty, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.ucText txtPrimaryQty;
        private MyControls.ucText txtDescription;
        private MyControls.ucText txtName;

    }
}
