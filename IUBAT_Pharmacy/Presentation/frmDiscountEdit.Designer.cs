namespace IUBAT_Pharmacy.Presentation
{
    partial class frmDiscountEdit
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
            this.txtPersentage = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtDiscount = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(316, 159);
            this.btnExit.Size = new System.Drawing.Size(87, 27);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(13, 159);
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPersentage
            // 
            this.txtPersentage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersentage.AutoSize = true;
            this.txtPersentage.Location = new System.Drawing.Point(13, 90);
            this.txtPersentage.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtPersentage.MultiLine = false;
            this.txtPersentage.Name = "txtPersentage";
            this.txtPersentage.Size = new System.Drawing.Size(390, 40);
            this.txtPersentage.TabIndex = 5;
            this.txtPersentage.txtDoubleValue = 0D;
            this.txtPersentage.txtFloatValue = 0F;
            this.txtPersentage.txtIntValue = 0;
            this.txtPersentage.txtRequired = false;
            this.txtPersentage.txtTextLabel = "Persentage";
            this.txtPersentage.txtTextValue = "";
            this.txtPersentage.TxtType = TextType.Float;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.AutoSize = true;
            this.txtDiscount.Location = new System.Drawing.Point(13, 23);
            this.txtDiscount.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtDiscount.MultiLine = false;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(390, 40);
            this.txtDiscount.TabIndex = 4;
            this.txtDiscount.txtDoubleValue = 0D;
            this.txtDiscount.txtFloatValue = 0F;
            this.txtDiscount.txtIntValue = 0;
            this.txtDiscount.txtRequired = true;
            this.txtDiscount.txtTextLabel = "Discount Status";
            this.txtDiscount.txtTextValue = "";
            this.txtDiscount.TxtType = TextType.Text;
            // 
            // frmDiscountEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(408, 198);
            this.Controls.Add(this.txtPersentage);
            this.Controls.Add(this.txtDiscount);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmDiscountEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDIT DISCOUNT INFORMATION";
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.txtDiscount, 0);
            this.Controls.SetChildIndex(this.txtPersentage, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.ucText txtPersentage;
        private MyControls.ucText txtDiscount;
    }
}
