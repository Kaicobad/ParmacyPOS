namespace IUBAT_Pharmacy.Presentation
{
    partial class frmSaleDetailsNew
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
            this.cmbCompany = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.cmbNumber = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.txtQuantity = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtRate = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtVat = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.cmbDiscount = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.cmbSaleStatus = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.dgvData = new IUBAT_Pharmacy.Presentation.MyControls.clsMyGrid();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleStatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbPaymentMethod = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dptDateTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployee = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(1015, 600);
            this.btnExit.Size = new System.Drawing.Size(87, 27);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(3, 600);
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbProduct
            // 
            this.cmbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProduct.AutoSize = true;
            this.cmbProduct.Location = new System.Drawing.Point(870, 27);
            this.cmbProduct.MinimumSize = new System.Drawing.Size(233, 40);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(233, 40);
            this.cmbProduct.TabIndex = 2;
            this.cmbProduct.txtComboText = "";
            this.cmbProduct.txtRequired = true;
            this.cmbProduct.txtTextLabel = "Medicine Name";
            this.cmbProduct.txtTextValueDouble = 0D;
            this.cmbProduct.txtTextValueInt = 0;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // cmbCompany
            // 
            this.cmbCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCompany.AutoSize = true;
            this.cmbCompany.Location = new System.Drawing.Point(873, 77);
            this.cmbCompany.MinimumSize = new System.Drawing.Size(233, 40);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(233, 40);
            this.cmbCompany.TabIndex = 3;
            this.cmbCompany.txtComboText = "";
            this.cmbCompany.txtRequired = true;
            this.cmbCompany.txtTextLabel = "Company / Menufecturar";
            this.cmbCompany.txtTextValueDouble = 0D;
            this.cmbCompany.txtTextValueInt = 0;
            // 
            // cmbNumber
            // 
            this.cmbNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNumber.AutoSize = true;
            this.cmbNumber.Location = new System.Drawing.Point(872, 206);
            this.cmbNumber.MinimumSize = new System.Drawing.Size(233, 40);
            this.cmbNumber.Name = "cmbNumber";
            this.cmbNumber.Size = new System.Drawing.Size(233, 40);
            this.cmbNumber.TabIndex = 4;
            this.cmbNumber.txtComboText = "";
            this.cmbNumber.txtRequired = true;
            this.cmbNumber.txtTextLabel = "Code";
            this.cmbNumber.txtTextValueDouble = 0D;
            this.cmbNumber.txtTextValueInt = 0;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.AutoSize = true;
            this.txtQuantity.Location = new System.Drawing.Point(871, 344);
            this.txtQuantity.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtQuantity.MultiLine = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(233, 40);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.txtDoubleValue = 0D;
            this.txtQuantity.txtFloatValue = 0F;
            this.txtQuantity.txtIntValue = 0;
            this.txtQuantity.txtRequired = true;
            this.txtQuantity.txtTextLabel = "Quantity";
            this.txtQuantity.txtTextValue = "";
            this.txtQuantity.TxtType = TextType.Integer;
            // 
            // txtRate
            // 
            this.txtRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRate.AutoSize = true;
            this.txtRate.Location = new System.Drawing.Point(872, 119);
            this.txtRate.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtRate.MultiLine = false;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(233, 40);
            this.txtRate.TabIndex = 6;
            this.txtRate.txtDoubleValue = 0D;
            this.txtRate.txtFloatValue = 0F;
            this.txtRate.txtIntValue = 0;
            this.txtRate.txtRequired = true;
            this.txtRate.txtTextLabel = "Price of Medicine";
            this.txtRate.txtTextValue = "";
            this.txtRate.TxtType = TextType.Float;
            // 
            // txtVat
            // 
            this.txtVat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVat.AutoSize = true;
            this.txtVat.Location = new System.Drawing.Point(872, 165);
            this.txtVat.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtVat.MultiLine = false;
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(233, 40);
            this.txtVat.TabIndex = 7;
            this.txtVat.txtDoubleValue = 0D;
            this.txtVat.txtFloatValue = 0F;
            this.txtVat.txtIntValue = 0;
            this.txtVat.txtRequired = false;
            this.txtVat.txtTextLabel = "Vat(%)Taka";
            this.txtVat.txtTextValue = "";
            this.txtVat.TxtType = TextType.Float;
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDiscount.AutoSize = true;
            this.cmbDiscount.Location = new System.Drawing.Point(873, 252);
            this.cmbDiscount.MinimumSize = new System.Drawing.Size(233, 40);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(233, 40);
            this.cmbDiscount.TabIndex = 8;
            this.cmbDiscount.txtComboText = "";
            this.cmbDiscount.txtRequired = true;
            this.cmbDiscount.txtTextLabel = "Discount";
            this.cmbDiscount.txtTextValueDouble = 0D;
            this.cmbDiscount.txtTextValueInt = 0;
            // 
            // cmbSaleStatus
            // 
            this.cmbSaleStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSaleStatus.AutoSize = true;
            this.cmbSaleStatus.Location = new System.Drawing.Point(873, 391);
            this.cmbSaleStatus.MinimumSize = new System.Drawing.Size(233, 40);
            this.cmbSaleStatus.Name = "cmbSaleStatus";
            this.cmbSaleStatus.Size = new System.Drawing.Size(233, 40);
            this.cmbSaleStatus.TabIndex = 9;
            this.cmbSaleStatus.txtComboText = "";
            this.cmbSaleStatus.txtRequired = true;
            this.cmbSaleStatus.txtTextLabel = "SaleStatus";
            this.cmbSaleStatus.txtTextValueDouble = 0D;
            this.cmbSaleStatus.txtTextValueInt = 0;
            this.cmbSaleStatus.Load += new System.EventHandler(this.cmbSaleStatus_Load);
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
            this.colCompany,
            this.colNumber,
            this.colQty,
            this.colRate,
            this.colVat,
            this.colDiscount,
            this.colSaleStatus,
            this.colPaymentMethod,
            this.colSubTotal,
            this.colId,
            this.colCompanyId,
            this.colCodeId,
            this.colDiscountId,
            this.colSaleStatusId,
            this.colPaymentId});
            this.dgvData.Location = new System.Drawing.Point(3, 27);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(864, 531);
            this.dgvData.TabIndex = 10;
            // 
            // colProduct
            // 
            this.colProduct.HeaderText = "Medicine Name";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            // 
            // colCompany
            // 
            this.colCompany.HeaderText = "Menufecturar";
            this.colCompany.Name = "colCompany";
            this.colCompany.ReadOnly = true;
            // 
            // colNumber
            // 
            this.colNumber.HeaderText = "Code";
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Quantity";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colRate
            // 
            this.colRate.HeaderText = "Price Of Medicine";
            this.colRate.Name = "colRate";
            this.colRate.ReadOnly = true;
            // 
            // colVat
            // 
            this.colVat.HeaderText = "Vat";
            this.colVat.Name = "colVat";
            this.colVat.ReadOnly = true;
            // 
            // colDiscount
            // 
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            // 
            // colSaleStatus
            // 
            this.colSaleStatus.HeaderText = "Sale Status";
            this.colSaleStatus.Name = "colSaleStatus";
            this.colSaleStatus.ReadOnly = true;
            // 
            // colPaymentMethod
            // 
            this.colPaymentMethod.HeaderText = "Payment Method";
            this.colPaymentMethod.Name = "colPaymentMethod";
            this.colPaymentMethod.ReadOnly = true;
            // 
            // colSubTotal
            // 
            this.colSubTotal.HeaderText = "Sub Total";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.HeaderText = "ProductId";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colCompanyId
            // 
            this.colCompanyId.HeaderText = "CompanyId";
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.ReadOnly = true;
            this.colCompanyId.Visible = false;
            // 
            // colCodeId
            // 
            this.colCodeId.HeaderText = "CodeId";
            this.colCodeId.Name = "colCodeId";
            this.colCodeId.ReadOnly = true;
            this.colCodeId.Visible = false;
            // 
            // colDiscountId
            // 
            this.colDiscountId.HeaderText = "DiscountId";
            this.colDiscountId.Name = "colDiscountId";
            this.colDiscountId.ReadOnly = true;
            this.colDiscountId.Visible = false;
            // 
            // colSaleStatusId
            // 
            this.colSaleStatusId.HeaderText = "SaleStatusId";
            this.colSaleStatusId.Name = "colSaleStatusId";
            this.colSaleStatusId.ReadOnly = true;
            this.colSaleStatusId.Visible = false;
            // 
            // colPaymentId
            // 
            this.colPaymentId.HeaderText = "PaymentId";
            this.colPaymentId.Name = "colPaymentId";
            this.colPaymentId.ReadOnly = true;
            this.colPaymentId.Visible = false;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToCart.Location = new System.Drawing.Point(996, 531);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(97, 27);
            this.btnAddToCart.TabIndex = 11;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(873, 531);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 27);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear Cart";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPaymentMethod.AutoSize = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(873, 298);
            this.cmbPaymentMethod.MinimumSize = new System.Drawing.Size(233, 40);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(233, 40);
            this.cmbPaymentMethod.TabIndex = 14;
            this.cmbPaymentMethod.txtComboText = "";
            this.cmbPaymentMethod.txtRequired = true;
            this.cmbPaymentMethod.txtTextLabel = "Payment Method";
            this.cmbPaymentMethod.txtTextValueDouble = 0D;
            this.cmbPaymentMethod.txtTextValueInt = 0;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.Green;
            this.lblSubTotal.Location = new System.Drawing.Point(194, 606);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(0, 13);
            this.lblSubTotal.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblTotal.Location = new System.Drawing.Point(716, 602);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 2;
            // 
            // dptDateTime
            // 
            this.dptDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dptDateTime.CustomFormat = "yyyy-MM-dd";
            this.dptDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptDateTime.Location = new System.Drawing.Point(872, 499);
            this.dptDateTime.Name = "dptDateTime";
            this.dptDateTime.Size = new System.Drawing.Size(233, 21);
            this.dptDateTime.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(873, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Date :";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployee.AutoSize = true;
            this.txtEmployee.Location = new System.Drawing.Point(873, 434);
            this.txtEmployee.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtEmployee.MultiLine = true;
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(233, 40);
            this.txtEmployee.TabIndex = 19;
            this.txtEmployee.txtDoubleValue = 0D;
            this.txtEmployee.txtFloatValue = 0F;
            this.txtEmployee.txtIntValue = 0;
            this.txtEmployee.txtRequired = false;
            this.txtEmployee.txtTextLabel = "Employee";
            this.txtEmployee.txtTextValue = "";
            this.txtEmployee.TxtType = TextType.Text;
            // 
            // frmSaleDetailsNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1116, 632);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dptDateTime);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.cmbSaleStatus);
            this.Controls.Add(this.cmbDiscount);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbNumber);
            this.Controls.Add(this.cmbCompany);
            this.Controls.Add(this.cmbProduct);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmSaleDetailsNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEW SELL";
            this.Load += new System.EventHandler(this.frmSaleDetailsNew_Load);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.cmbProduct, 0);
            this.Controls.SetChildIndex(this.cmbCompany, 0);
            this.Controls.SetChildIndex(this.cmbNumber, 0);
            this.Controls.SetChildIndex(this.txtQuantity, 0);
            this.Controls.SetChildIndex(this.txtRate, 0);
            this.Controls.SetChildIndex(this.txtVat, 0);
            this.Controls.SetChildIndex(this.cmbDiscount, 0);
            this.Controls.SetChildIndex(this.cmbSaleStatus, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.btnAddToCart, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.cmbPaymentMethod, 0);
            this.Controls.SetChildIndex(this.lblSubTotal, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.dptDateTime, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtEmployee, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.ucCombo cmbProduct;
        private MyControls.ucCombo cmbCompany;
        private MyControls.ucCombo cmbNumber;
        private MyControls.ucText txtQuantity;
        private MyControls.ucText txtRate;
        private MyControls.ucText txtVat;
        private MyControls.ucCombo cmbDiscount;
        private MyControls.ucCombo cmbSaleStatus;
        private MyControls.clsMyGrid dgvData;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnClear;
        private MyControls.ucCombo cmbPaymentMethod;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker dptDateTime;
        private System.Windows.Forms.Label label3;
        private MyControls.ucText txtEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleStatusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentId;
    }
}
