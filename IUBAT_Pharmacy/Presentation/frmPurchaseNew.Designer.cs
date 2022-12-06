namespace IUBAT_Pharmacy.Presentation
{
    partial class frmPurchaseNew
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
            this.cmbProduct = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.dgvData = new IUBAT_Pharmacy.Presentation.MyControls.clsMyGrid();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtQty = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.cmbRate = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.cmbVat = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.cmbCode = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dptDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbDiscount = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.txtEmployee = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(848, 429);
            this.btnExit.Size = new System.Drawing.Size(87, 27);
            this.btnExit.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(12, 429);
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbProduct
            // 
            this.cmbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProduct.AutoSize = true;
            this.cmbProduct.Location = new System.Drawing.Point(699, 4);
            this.cmbProduct.MinimumSize = new System.Drawing.Size(233, 40);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(233, 40);
            this.cmbProduct.TabIndex = 0;
            this.cmbProduct.txtComboText = "";
            this.cmbProduct.txtRequired = true;
            this.cmbProduct.txtTextLabel = "Product";
            this.cmbProduct.txtTextValueDouble = 0D;
            this.cmbProduct.txtTextValueInt = 0;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProduct,
            this.colDiscount,
            this.colQty,
            this.colNumber,
            this.colRate,
            this.colVat,
            this.colSubTotal,
            this.colId,
            this.colDiscountId,
            this.colCodeId,
            this.colRateId,
            this.colVatId});
            this.dgvData.Location = new System.Drawing.Point(4, 4);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(688, 405);
            this.dgvData.TabIndex = 16;
            // 
            // colProduct
            // 
            this.colProduct.HeaderText = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            // 
            // colDiscount
            // 
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Quantity";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colNumber
            // 
            this.colNumber.HeaderText = "Code";
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            // 
            // colRate
            // 
            this.colRate.HeaderText = "Rate";
            this.colRate.Name = "colRate";
            this.colRate.ReadOnly = true;
            // 
            // colVat
            // 
            this.colVat.HeaderText = "Vat";
            this.colVat.Name = "colVat";
            this.colVat.ReadOnly = true;
            // 
            // colSubTotal
            // 
            this.colSubTotal.HeaderText = "Sub-Total";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colDiscountId
            // 
            this.colDiscountId.HeaderText = "DiscountId";
            this.colDiscountId.Name = "colDiscountId";
            this.colDiscountId.ReadOnly = true;
            this.colDiscountId.Visible = false;
            // 
            // colCodeId
            // 
            this.colCodeId.HeaderText = "CodeId";
            this.colCodeId.Name = "colCodeId";
            this.colCodeId.ReadOnly = true;
            this.colCodeId.Visible = false;
            // 
            // colRateId
            // 
            this.colRateId.HeaderText = "RateId";
            this.colRateId.Name = "colRateId";
            this.colRateId.ReadOnly = true;
            this.colRateId.Visible = false;
            // 
            // colVatId
            // 
            this.colVatId.HeaderText = "VatId";
            this.colVatId.Name = "colVatId";
            this.colVatId.ReadOnly = true;
            this.colVatId.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(699, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date_Time";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.Blue;
            this.lblSubtotal.Location = new System.Drawing.Point(645, 441);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(0, 18);
            this.lblSubtotal.TabIndex = 10;
            // 
            // txtQty
            // 
            this.txtQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQty.AutoSize = true;
            this.txtQty.Location = new System.Drawing.Point(702, 234);
            this.txtQty.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtQty.MultiLine = false;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(233, 40);
            this.txtQty.TabIndex = 1;
            this.txtQty.txtDoubleValue = 0D;
            this.txtQty.txtFloatValue = 0F;
            this.txtQty.txtIntValue = 0;
            this.txtQty.txtRequired = true;
            this.txtQty.txtTextLabel = "Quantity";
            this.txtQty.txtTextValue = "";
            this.txtQty.TxtType = TextType.Integer;
            // 
            // cmbRate
            // 
            this.cmbRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRate.AutoSize = true;
            this.cmbRate.Location = new System.Drawing.Point(700, 96);
            this.cmbRate.MinimumSize = new System.Drawing.Size(233, 40);
            this.cmbRate.Name = "cmbRate";
            this.cmbRate.Size = new System.Drawing.Size(233, 40);
            this.cmbRate.TabIndex = 3;
            this.cmbRate.txtComboText = "";
            this.cmbRate.txtRequired = true;
            this.cmbRate.txtTextLabel = "Rate";
            this.cmbRate.txtTextValueDouble = 0D;
            this.cmbRate.txtTextValueInt = 0;
            // 
            // cmbVat
            // 
            this.cmbVat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVat.AutoSize = true;
            this.cmbVat.Location = new System.Drawing.Point(702, 188);
            this.cmbVat.MinimumSize = new System.Drawing.Size(233, 40);
            this.cmbVat.Name = "cmbVat";
            this.cmbVat.Size = new System.Drawing.Size(233, 40);
            this.cmbVat.TabIndex = 4;
            this.cmbVat.txtComboText = "";
            this.cmbVat.txtRequired = true;
            this.cmbVat.txtTextLabel = "Vat(%)BDT";
            this.cmbVat.txtTextValueDouble = 0D;
            this.cmbVat.txtTextValueInt = 0;
            // 
            // cmbCode
            // 
            this.cmbCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCode.AutoSize = true;
            this.cmbCode.Location = new System.Drawing.Point(700, 50);
            this.cmbCode.MinimumSize = new System.Drawing.Size(233, 40);
            this.cmbCode.Name = "cmbCode";
            this.cmbCode.Size = new System.Drawing.Size(233, 40);
            this.cmbCode.TabIndex = 5;
            this.cmbCode.txtComboText = "";
            this.cmbCode.txtRequired = true;
            this.cmbCode.txtTextLabel = "Code Number";
            this.cmbCode.txtTextValueDouble = 0D;
            this.cmbCode.txtTextValueInt = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotal.Location = new System.Drawing.Point(149, 441);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 18);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total :";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(836, 382);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 27);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(476, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "SubTotal (BDT) :";
            // 
            // dptDateTime
            // 
            this.dptDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dptDateTime.CustomFormat = "M-dd-yyyy";
            this.dptDateTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dptDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptDateTime.Location = new System.Drawing.Point(702, 296);
            this.dptDateTime.Name = "dptDateTime";
            this.dptDateTime.Size = new System.Drawing.Size(233, 21);
            this.dptDateTime.TabIndex = 3;
            this.dptDateTime.Value = new System.DateTime(2017, 3, 7, 0, 0, 0, 0);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(702, 382);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 27);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDiscount.AutoSize = true;
            this.cmbDiscount.Location = new System.Drawing.Point(702, 142);
            this.cmbDiscount.MinimumSize = new System.Drawing.Size(233, 40);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(233, 40);
            this.cmbDiscount.TabIndex = 5;
            this.cmbDiscount.txtComboText = "";
            this.cmbDiscount.txtRequired = true;
            this.cmbDiscount.txtTextLabel = "Discount";
            this.cmbDiscount.txtTextValueDouble = 0D;
            this.cmbDiscount.txtTextValueInt = 0;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployee.AutoSize = true;
            this.txtEmployee.Location = new System.Drawing.Point(702, 323);
            this.txtEmployee.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtEmployee.MultiLine = true;
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(233, 40);
            this.txtEmployee.TabIndex = 17;
            this.txtEmployee.txtDoubleValue = 0D;
            this.txtEmployee.txtFloatValue = 0F;
            this.txtEmployee.txtIntValue = 0;
            this.txtEmployee.txtRequired = false;
            this.txtEmployee.txtTextLabel = "Employee";
            this.txtEmployee.txtTextValue = "";
            this.txtEmployee.TxtType = TextType.Text;
            // 
            // frmPurchaseNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(947, 467);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dptDateTime);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cmbCode);
            this.Controls.Add(this.cmbDiscount);
            this.Controls.Add(this.cmbVat);
            this.Controls.Add(this.cmbRate);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.cmbProduct);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmPurchaseNew";
            this.Text = "NEW PURCHASE";
            this.Load += new System.EventHandler(this.frmPurchaseNew_Load);
            this.Controls.SetChildIndex(this.cmbProduct, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblSubtotal, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtQty, 0);
            this.Controls.SetChildIndex(this.cmbRate, 0);
            this.Controls.SetChildIndex(this.cmbVat, 0);
            this.Controls.SetChildIndex(this.cmbDiscount, 0);
            this.Controls.SetChildIndex(this.cmbCode, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.dptDateTime, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.txtEmployee, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.ucCombo cmbProduct;
        private MyControls.clsMyGrid dgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubtotal;
        private MyControls.ucText txtQty;
        private MyControls.ucCombo cmbRate;
        private MyControls.ucCombo cmbVat;
        private MyControls.ucCombo cmbCode;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dptDateTime;
        private System.Windows.Forms.Button btnClear;
        private MyControls.ucCombo cmbDiscount;
        private MyControls.ucText txtEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVatId;
    }
}
