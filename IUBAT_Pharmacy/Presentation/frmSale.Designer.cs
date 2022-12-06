namespace IUBAT_Pharmacy.Presentation
{
    partial class frmSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvData = new IUBAT_Pharmacy.Presentation.MyControls.clsMyGrid();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleStatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpaymentMethodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSold = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSearchInt = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.dptDateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dptDateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.chkDateTime = new System.Windows.Forms.CheckBox();
            this.dgvData2 = new IUBAT_Pharmacy.Presentation.MyControls.clsMyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(242, 13);
            this.btnSearch.Size = new System.Drawing.Size(87, 27);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(573, 13);
            this.btnNew.Size = new System.Drawing.Size(87, 27);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(679, 13);
            this.btnEdit.Size = new System.Drawing.Size(87, 27);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(784, 13);
            this.btnDelete.Size = new System.Drawing.Size(87, 27);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(882, 13);
            this.btnPrint.Size = new System.Drawing.Size(87, 27);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(3, 12);
            this.txtSearch.Multiline = true;
            this.txtSearch.Size = new System.Drawing.Size(168, 21);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colSaleId,
            this.colProduct,
            this.colCompany,
            this.colCode,
            this.colQty,
            this.colRate,
            this.colVat,
            this.colDiscount,
            this.colSaleStatus,
            this.colPaymentMethod,
            this.colSubTotal,
            this.colDateTime,
            this.colEmployee,
            this.colCompanyId,
            this.colDiscountId,
            this.colSaleStatusId,
            this.colpaymentMethodId,
            this.colProductId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvData.Location = new System.Drawing.Point(3, 73);
            this.dgvData.MinimumSize = new System.Drawing.Size(48, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(753, 323);
            this.dgvData.TabIndex = 6;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "DetailsId";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colSaleId
            // 
            this.colSaleId.DataPropertyName = "SaleId";
            this.colSaleId.HeaderText = "SaleId";
            this.colSaleId.Name = "colSaleId";
            this.colSaleId.ReadOnly = true;
            // 
            // colProduct
            // 
            this.colProduct.DataPropertyName = "product";
            this.colProduct.HeaderText = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            // 
            // colCompany
            // 
            this.colCompany.DataPropertyName = "company";
            this.colCompany.HeaderText = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.ReadOnly = true;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "code";
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "qty";
            this.colQty.HeaderText = "Quantity";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colRate
            // 
            this.colRate.DataPropertyName = "rate";
            this.colRate.HeaderText = "Rate";
            this.colRate.Name = "colRate";
            this.colRate.ReadOnly = true;
            // 
            // colVat
            // 
            this.colVat.DataPropertyName = "vat";
            this.colVat.HeaderText = "Vat";
            this.colVat.Name = "colVat";
            this.colVat.ReadOnly = true;
            // 
            // colDiscount
            // 
            this.colDiscount.DataPropertyName = "discount";
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            // 
            // colSaleStatus
            // 
            this.colSaleStatus.DataPropertyName = "saleStatus";
            this.colSaleStatus.HeaderText = "Sale Status";
            this.colSaleStatus.Name = "colSaleStatus";
            this.colSaleStatus.ReadOnly = true;
            // 
            // colPaymentMethod
            // 
            this.colPaymentMethod.DataPropertyName = "paymentMethod";
            this.colPaymentMethod.HeaderText = "Payment Method";
            this.colPaymentMethod.Name = "colPaymentMethod";
            this.colPaymentMethod.ReadOnly = true;
            // 
            // colSubTotal
            // 
            this.colSubTotal.DataPropertyName = "subTotal";
            this.colSubTotal.HeaderText = "Sub-Total";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            // 
            // colDateTime
            // 
            this.colDateTime.DataPropertyName = "dateTime";
            this.colDateTime.HeaderText = "Date and Time";
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.ReadOnly = true;
            // 
            // colEmployee
            // 
            this.colEmployee.DataPropertyName = "employee";
            this.colEmployee.HeaderText = "Employee";
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.ReadOnly = true;
            // 
            // colCompanyId
            // 
            this.colCompanyId.DataPropertyName = "CompanyId";
            this.colCompanyId.HeaderText = "CompanyId";
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.ReadOnly = true;
            this.colCompanyId.Visible = false;
            // 
            // colDiscountId
            // 
            this.colDiscountId.DataPropertyName = "DiscountId";
            this.colDiscountId.HeaderText = "DiscountId";
            this.colDiscountId.Name = "colDiscountId";
            this.colDiscountId.ReadOnly = true;
            this.colDiscountId.Visible = false;
            // 
            // colSaleStatusId
            // 
            this.colSaleStatusId.DataPropertyName = "SaleStatusId";
            this.colSaleStatusId.HeaderText = "SaleStatusId";
            this.colSaleStatusId.Name = "colSaleStatusId";
            this.colSaleStatusId.ReadOnly = true;
            this.colSaleStatusId.Visible = false;
            // 
            // colpaymentMethodId
            // 
            this.colpaymentMethodId.DataPropertyName = "paymentMethodId";
            this.colpaymentMethodId.HeaderText = "PaymentMethodId";
            this.colpaymentMethodId.Name = "colpaymentMethodId";
            this.colpaymentMethodId.ReadOnly = true;
            this.colpaymentMethodId.Visible = false;
            // 
            // colProductId
            // 
            this.colProductId.DataPropertyName = "productId";
            this.colProductId.HeaderText = "ProductId";
            this.colProductId.Name = "colProductId";
            this.colProductId.ReadOnly = true;
            this.colProductId.Visible = false;
            // 
            // lblSold
            // 
            this.lblSold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSold.AutoSize = true;
            this.lblSold.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSold.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblSold.Location = new System.Drawing.Point(10, 399);
            this.lblSold.Name = "lblSold";
            this.lblSold.Size = new System.Drawing.Size(0, 19);
            this.lblSold.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblTotal.Location = new System.Drawing.Point(678, 399);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 19);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtSearchInt
            // 
            this.txtSearchInt.AutoSize = true;
            this.txtSearchInt.Location = new System.Drawing.Point(3, 0);
            this.txtSearchInt.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtSearchInt.MultiLine = true;
            this.txtSearchInt.Name = "txtSearchInt";
            this.txtSearchInt.Size = new System.Drawing.Size(233, 40);
            this.txtSearchInt.TabIndex = 10;
            this.txtSearchInt.txtDoubleValue = 0D;
            this.txtSearchInt.txtFloatValue = 0F;
            this.txtSearchInt.txtIntValue = 0;
            this.txtSearchInt.txtRequired = false;
            this.txtSearchInt.txtTextLabel = "Search SaleDetail Id";
            this.txtSearchInt.txtTextValue = "";
            this.txtSearchInt.TxtType = TextType.Integer;
            // 
            // dptDateTimeFrom
            // 
            this.dptDateTimeFrom.CustomFormat = "yyyy.MM.dd";
            this.dptDateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptDateTimeFrom.Location = new System.Drawing.Point(353, 19);
            this.dptDateTimeFrom.Name = "dptDateTimeFrom";
            this.dptDateTimeFrom.Size = new System.Drawing.Size(91, 21);
            this.dptDateTimeFrom.TabIndex = 11;
            // 
            // dptDateTimeTo
            // 
            this.dptDateTimeTo.CustomFormat = "yyyy-MM-dd";
            this.dptDateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptDateTimeTo.Location = new System.Drawing.Point(472, 19);
            this.dptDateTimeTo.Name = "dptDateTimeTo";
            this.dptDateTimeTo.Size = new System.Drawing.Size(95, 21);
            this.dptDateTimeTo.TabIndex = 12;
            // 
            // chkDateTime
            // 
            this.chkDateTime.AutoSize = true;
            this.chkDateTime.Location = new System.Drawing.Point(353, 0);
            this.chkDateTime.Name = "chkDateTime";
            this.chkDateTime.Size = new System.Drawing.Size(219, 19);
            this.chkDateTime.TabIndex = 13;
            this.chkDateTime.Text = "Click TO Active Date to Date Search";
            this.chkDateTime.UseVisualStyleBackColor = true;
            // 
            // dgvData2
            // 
            this.dgvData2.AllowUserToAddRows = false;
            this.dgvData2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvData2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvData2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dgvData2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvData2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvData2.Location = new System.Drawing.Point(762, 73);
            this.dgvData2.MinimumSize = new System.Drawing.Size(48, 0);
            this.dgvData2.Name = "dgvData2";
            this.dgvData2.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvData2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgvData2.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvData2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData2.Size = new System.Drawing.Size(207, 323);
            this.dgvData2.TabIndex = 6;
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 444);
            this.Controls.Add(this.chkDateTime);
            this.Controls.Add(this.dptDateTimeTo);
            this.Controls.Add(this.dptDateTimeFrom);
            this.Controls.Add(this.txtSearchInt);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSold);
            this.Controls.Add(this.dgvData2);
            this.Controls.Add(this.dgvData);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIAPLAY SELLING DETAILS";
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.dgvData2, 0);
            this.Controls.SetChildIndex(this.lblSold, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.txtSearchInt, 0);
            this.Controls.SetChildIndex(this.dptDateTimeFrom, 0);
            this.Controls.SetChildIndex(this.dptDateTimeTo, 0);
            this.Controls.SetChildIndex(this.chkDateTime, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSold;
        private System.Windows.Forms.Label lblTotal;
        private MyControls.clsMyGrid dgvData;
        public MyControls.ucText txtSearchInt;
        public System.Windows.Forms.DateTimePicker dptDateTimeFrom;
        public System.Windows.Forms.DateTimePicker dptDateTimeTo;
        private System.Windows.Forms.CheckBox chkDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleStatusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpaymentMethodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private MyControls.clsMyGrid dgvData2;
    }
}
