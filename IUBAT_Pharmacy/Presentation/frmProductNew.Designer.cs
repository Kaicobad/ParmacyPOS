namespace IUBAT_Pharmacy.Presentation
{
    partial class frmProductEdit
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
            this.txtCode = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.cmbPowerId = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.cmbCompanyId = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.cmbCategoryId = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.cmbUnitId = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.cmbDiscountId = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.cmbSaleStatusId = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.txtListPrice = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtVat = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtRemarks = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.cmbGroupId = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(309, 592);
            this.btnExit.Size = new System.Drawing.Size(87, 36);
            this.btnExit.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(14, 592);
            this.btnSave.Size = new System.Drawing.Size(87, 36);
            this.btnSave.TabIndex = 12;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(15, 16);
            this.txtName.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtName.MultiLine = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(381, 46);
            this.txtName.TabIndex = 0;
            this.txtName.txtDoubleValue = 0D;
            this.txtName.txtFloatValue = 0F;
            this.txtName.txtIntValue = 0;
            this.txtName.txtRequired = true;
            this.txtName.txtTextLabel = "Product Name";
            this.txtName.txtTextValue = "";
            this.txtName.TxtType = TextType.Text;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.AutoSize = true;
            this.txtCode.Location = new System.Drawing.Point(15, 62);
            this.txtCode.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtCode.MultiLine = false;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(381, 46);
            this.txtCode.TabIndex = 1;
            this.txtCode.txtDoubleValue = 0D;
            this.txtCode.txtFloatValue = 0F;
            this.txtCode.txtIntValue = 0;
            this.txtCode.txtRequired = true;
            this.txtCode.txtTextLabel = "Code";
            this.txtCode.txtTextValue = "";
            this.txtCode.TxtType = TextType.Text;
            // 
            // cmbPowerId
            // 
            this.cmbPowerId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPowerId.AutoSize = true;
            this.cmbPowerId.Location = new System.Drawing.Point(14, 154);
            this.cmbPowerId.MinimumSize = new System.Drawing.Size(233, 40);
            this.cmbPowerId.Name = "cmbPowerId";
            this.cmbPowerId.Size = new System.Drawing.Size(381, 46);
            this.cmbPowerId.TabIndex = 3;
            this.cmbPowerId.txtComboText = "";
            this.cmbPowerId.txtRequired = false;
            this.cmbPowerId.txtTextLabel = "Power";
            this.cmbPowerId.txtTextValueDouble = 0D;
            this.cmbPowerId.txtTextValueInt = 0;
            // 
            // cmbCompanyId
            // 
            this.cmbCompanyId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCompanyId.AutoSize = true;
            this.cmbCompanyId.Location = new System.Drawing.Point(14, 201);
            this.cmbCompanyId.MinimumSize = new System.Drawing.Size(233, 40);
            this.cmbCompanyId.Name = "cmbCompanyId";
            this.cmbCompanyId.Size = new System.Drawing.Size(381, 46);
            this.cmbCompanyId.TabIndex = 4;
            this.cmbCompanyId.txtComboText = "";
            this.cmbCompanyId.txtRequired = true;
            this.cmbCompanyId.txtTextLabel = "Company";
            this.cmbCompanyId.txtTextValueDouble = 0D;
            this.cmbCompanyId.txtTextValueInt = 0;
            // 
            // cmbCategoryId
            // 
            this.cmbCategoryId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategoryId.AutoSize = true;
            this.cmbCategoryId.Location = new System.Drawing.Point(14, 248);
            this.cmbCategoryId.MinimumSize = new System.Drawing.Size(233, 40);
            this.cmbCategoryId.Name = "cmbCategoryId";
            this.cmbCategoryId.Size = new System.Drawing.Size(381, 46);
            this.cmbCategoryId.TabIndex = 5;
            this.cmbCategoryId.txtComboText = "";
            this.cmbCategoryId.txtRequired = true;
            this.cmbCategoryId.txtTextLabel = "Category";
            this.cmbCategoryId.txtTextValueDouble = 0D;
            this.cmbCategoryId.txtTextValueInt = 0;
            // 
            // cmbUnitId
            // 
            this.cmbUnitId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUnitId.AutoSize = true;
            this.cmbUnitId.Location = new System.Drawing.Point(15, 296);
            this.cmbUnitId.MinimumSize = new System.Drawing.Size(233, 40);
            this.cmbUnitId.Name = "cmbUnitId";
            this.cmbUnitId.Size = new System.Drawing.Size(381, 46);
            this.cmbUnitId.TabIndex = 6;
            this.cmbUnitId.txtComboText = "";
            this.cmbUnitId.txtRequired = true;
            this.cmbUnitId.txtTextLabel = "Unit";
            this.cmbUnitId.txtTextValueDouble = 0D;
            this.cmbUnitId.txtTextValueInt = 0;
            // 
            // cmbDiscountId
            // 
            this.cmbDiscountId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDiscountId.AutoSize = true;
            this.cmbDiscountId.Location = new System.Drawing.Point(15, 344);
            this.cmbDiscountId.MinimumSize = new System.Drawing.Size(233, 40);
            this.cmbDiscountId.Name = "cmbDiscountId";
            this.cmbDiscountId.Size = new System.Drawing.Size(381, 46);
            this.cmbDiscountId.TabIndex = 7;
            this.cmbDiscountId.txtComboText = "";
            this.cmbDiscountId.txtRequired = false;
            this.cmbDiscountId.txtTextLabel = "Discount";
            this.cmbDiscountId.txtTextValueDouble = 0D;
            this.cmbDiscountId.txtTextValueInt = 0;
            // 
            // cmbSaleStatusId
            // 
            this.cmbSaleStatusId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSaleStatusId.AutoSize = true;
            this.cmbSaleStatusId.Location = new System.Drawing.Point(14, 391);
            this.cmbSaleStatusId.MinimumSize = new System.Drawing.Size(233, 40);
            this.cmbSaleStatusId.Name = "cmbSaleStatusId";
            this.cmbSaleStatusId.Size = new System.Drawing.Size(381, 46);
            this.cmbSaleStatusId.TabIndex = 8;
            this.cmbSaleStatusId.txtComboText = "";
            this.cmbSaleStatusId.txtRequired = true;
            this.cmbSaleStatusId.txtTextLabel = "SaleStatus";
            this.cmbSaleStatusId.txtTextValueDouble = 0D;
            this.cmbSaleStatusId.txtTextValueInt = 0;
            // 
            // txtListPrice
            // 
            this.txtListPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtListPrice.AutoSize = true;
            this.txtListPrice.Location = new System.Drawing.Point(15, 437);
            this.txtListPrice.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtListPrice.MultiLine = false;
            this.txtListPrice.Name = "txtListPrice";
            this.txtListPrice.Size = new System.Drawing.Size(381, 46);
            this.txtListPrice.TabIndex = 9;
            this.txtListPrice.txtDoubleValue = 0D;
            this.txtListPrice.txtFloatValue = 0F;
            this.txtListPrice.txtIntValue = 0;
            this.txtListPrice.txtRequired = true;
            this.txtListPrice.txtTextLabel = "List Price";
            this.txtListPrice.txtTextValue = "";
            this.txtListPrice.TxtType = TextType.Text;
            // 
            // txtVat
            // 
            this.txtVat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVat.AutoSize = true;
            this.txtVat.Location = new System.Drawing.Point(15, 484);
            this.txtVat.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtVat.MultiLine = false;
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(381, 46);
            this.txtVat.TabIndex = 10;
            this.txtVat.txtDoubleValue = 0D;
            this.txtVat.txtFloatValue = 0F;
            this.txtVat.txtIntValue = 0;
            this.txtVat.txtRequired = true;
            this.txtVat.txtTextLabel = "Vat";
            this.txtVat.txtTextValue = "";
            this.txtVat.TxtType = TextType.Text;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.AutoSize = true;
            this.txtRemarks.Location = new System.Drawing.Point(15, 531);
            this.txtRemarks.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtRemarks.MultiLine = false;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(381, 46);
            this.txtRemarks.TabIndex = 11;
            this.txtRemarks.txtDoubleValue = 0D;
            this.txtRemarks.txtFloatValue = 0F;
            this.txtRemarks.txtIntValue = 0;
            this.txtRemarks.txtRequired = false;
            this.txtRemarks.txtTextLabel = "Remarks";
            this.txtRemarks.txtTextValue = "";
            this.txtRemarks.TxtType = TextType.Text;
            // 
            // cmbGroupId
            // 
            this.cmbGroupId.AutoSize = true;
            this.cmbGroupId.Location = new System.Drawing.Point(15, 107);
            this.cmbGroupId.MinimumSize = new System.Drawing.Size(233, 40);
            this.cmbGroupId.Name = "cmbGroupId";
            this.cmbGroupId.Size = new System.Drawing.Size(381, 46);
            this.cmbGroupId.TabIndex = 2;
            this.cmbGroupId.txtComboText = "";
            this.cmbGroupId.txtRequired = true;
            this.cmbGroupId.txtTextLabel = "Group";
            this.cmbGroupId.txtTextValueDouble = 0D;
            this.cmbGroupId.txtTextValueInt = 0;
            // 
            // frmProductNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(411, 633);
            this.Controls.Add(this.cmbGroupId);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.txtListPrice);
            this.Controls.Add(this.cmbSaleStatusId);
            this.Controls.Add(this.cmbDiscountId);
            this.Controls.Add(this.cmbUnitId);
            this.Controls.Add(this.cmbCategoryId);
            this.Controls.Add(this.cmbCompanyId);
            this.Controls.Add(this.cmbPowerId);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmProductNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD NEW PRODUCT";
            this.Load += new System.EventHandler(this.frmProductNew_Load);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtCode, 0);
            this.Controls.SetChildIndex(this.cmbPowerId, 0);
            this.Controls.SetChildIndex(this.cmbCompanyId, 0);
            this.Controls.SetChildIndex(this.cmbCategoryId, 0);
            this.Controls.SetChildIndex(this.cmbUnitId, 0);
            this.Controls.SetChildIndex(this.cmbDiscountId, 0);
            this.Controls.SetChildIndex(this.cmbSaleStatusId, 0);
            this.Controls.SetChildIndex(this.txtListPrice, 0);
            this.Controls.SetChildIndex(this.txtVat, 0);
            this.Controls.SetChildIndex(this.txtRemarks, 0);
            this.Controls.SetChildIndex(this.cmbGroupId, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.ucText txtName;
        private MyControls.ucText txtCode;
        private MyControls.ucCombo cmbPowerId;
        private MyControls.ucCombo cmbCompanyId;
        private MyControls.ucCombo cmbCategoryId;
        private MyControls.ucCombo cmbUnitId;
        private MyControls.ucCombo cmbDiscountId;
        private MyControls.ucCombo cmbSaleStatusId;
        private MyControls.ucText txtListPrice;
        private MyControls.ucText txtVat;
        private MyControls.ucText txtRemarks;
        private MyControls.ucCombo cmbGroupId;
    }
}

