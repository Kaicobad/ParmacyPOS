namespace IUBAT_Pharmacy.Presentation
{
    partial class frmPurchase
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
            this.lablel1 = new System.Windows.Forms.Label();
            this.lblProductCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.dgvData = new IUBAT_Pharmacy.Presentation.MyControls.clsMyGrid();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTextInt = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.chkDatetime = new System.Windows.Forms.CheckBox();
            this.dptDateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dptDateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dgvData2 = new IUBAT_Pharmacy.Presentation.MyControls.clsMyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(242, 20);
            this.btnSearch.Size = new System.Drawing.Size(87, 27);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(718, 22);
            this.btnNew.Size = new System.Drawing.Size(87, 27);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(822, 22);
            this.btnEdit.Size = new System.Drawing.Size(87, 27);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(924, 22);
            this.btnDelete.Size = new System.Drawing.Size(87, 27);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(1017, 22);
            this.btnPrint.Size = new System.Drawing.Size(87, 27);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Size = new System.Drawing.Size(145, 21);
            // 
            // lablel1
            // 
            this.lablel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lablel1.AutoSize = true;
            this.lablel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lablel1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablel1.ForeColor = System.Drawing.Color.Black;
            this.lablel1.Location = new System.Drawing.Point(6, 360);
            this.lablel1.Name = "lablel1";
            this.lablel1.Size = new System.Drawing.Size(104, 17);
            this.lablel1.TabIndex = 7;
            this.lablel1.Text = "Total Product :";
            // 
            // lblProductCount
            // 
            this.lblProductCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProductCount.AutoSize = true;
            this.lblProductCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductCount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCount.ForeColor = System.Drawing.Color.Black;
            this.lblProductCount.Location = new System.Drawing.Point(117, 360);
            this.lblProductCount.Name = "lblProductCount";
            this.lblProductCount.Size = new System.Drawing.Size(2, 17);
            this.lblProductCount.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(916, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total  BDT :";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(1006, 360);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(2, 17);
            this.lblTotal.TabIndex = 10;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuantity.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblQuantity.Location = new System.Drawing.Point(463, 360);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(57, 17);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "Quantity";
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
            this.colId,
            this.colProduct,
            this.colQty,
            this.colRate,
            this.colVat,
            this.colSubTotal,
            this.colDiscount,
            this.dateTime,
            this.colEmployeeID,
            this.colDiscountId,
            this.colProductId});
            this.dgvData.Location = new System.Drawing.Point(3, 72);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(826, 266);
            this.dgvData.TabIndex = 6;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colProduct
            // 
            this.colProduct.DataPropertyName = "product";
            this.colProduct.HeaderText = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "qty";
            this.colQty.HeaderText = "QTY";
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
            // colSubTotal
            // 
            this.colSubTotal.DataPropertyName = "subTotal";
            this.colSubTotal.HeaderText = "Subtotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            // 
            // colDiscount
            // 
            this.colDiscount.DataPropertyName = "discount";
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            // 
            // dateTime
            // 
            this.dateTime.DataPropertyName = "dateTime";
            this.dateTime.HeaderText = "Date";
            this.dateTime.Name = "dateTime";
            this.dateTime.ReadOnly = true;
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.DataPropertyName = "employeeId";
            this.colEmployeeID.HeaderText = "EmployeeId";
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.ReadOnly = true;
            this.colEmployeeID.Visible = false;
            // 
            // colDiscountId
            // 
            this.colDiscountId.DataPropertyName = "discountId";
            this.colDiscountId.HeaderText = "DiscountId";
            this.colDiscountId.Name = "colDiscountId";
            this.colDiscountId.ReadOnly = true;
            this.colDiscountId.Visible = false;
            // 
            // colProductId
            // 
            this.colProductId.DataPropertyName = "productId";
            this.colProductId.HeaderText = "ProductId";
            this.colProductId.Name = "colProductId";
            this.colProductId.ReadOnly = true;
            this.colProductId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "To";
            // 
            // txtTextInt
            // 
            this.txtTextInt.AutoSize = true;
            this.txtTextInt.Location = new System.Drawing.Point(3, 3);
            this.txtTextInt.MinimumSize = new System.Drawing.Size(233, 40);
            this.txtTextInt.MultiLine = true;
            this.txtTextInt.Name = "txtTextInt";
            this.txtTextInt.Size = new System.Drawing.Size(233, 40);
            this.txtTextInt.TabIndex = 14;
            this.txtTextInt.txtDoubleValue = 0D;
            this.txtTextInt.txtFloatValue = 0F;
            this.txtTextInt.txtIntValue = 0;
            this.txtTextInt.txtRequired = false;
            this.txtTextInt.txtTextLabel = "Search";
            this.txtTextInt.txtTextValue = "";
            this.txtTextInt.TxtType = TextType.Integer;
            // 
            // chkDatetime
            // 
            this.chkDatetime.AutoSize = true;
            this.chkDatetime.Location = new System.Drawing.Point(379, 6);
            this.chkDatetime.Name = "chkDatetime";
            this.chkDatetime.Size = new System.Drawing.Size(126, 19);
            this.chkDatetime.TabIndex = 15;
            this.chkDatetime.Text = "Active Date Search";
            this.chkDatetime.UseVisualStyleBackColor = true;
            this.chkDatetime.CheckedChanged += new System.EventHandler(this.chkDatetime_CheckedChanged);
            // 
            // dptDateTimeFrom
            // 
            this.dptDateTimeFrom.CustomFormat = "yyyy-MM-dd";
            this.dptDateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptDateTimeFrom.Location = new System.Drawing.Point(380, 26);
            this.dptDateTimeFrom.Name = "dptDateTimeFrom";
            this.dptDateTimeFrom.Size = new System.Drawing.Size(140, 21);
            this.dptDateTimeFrom.TabIndex = 16;
            // 
            // dptDateTimeTo
            // 
            this.dptDateTimeTo.CustomFormat = "yyyy-MM-dd";
            this.dptDateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptDateTimeTo.Location = new System.Drawing.Point(555, 26);
            this.dptDateTimeTo.Name = "dptDateTimeTo";
            this.dptDateTimeTo.Size = new System.Drawing.Size(140, 21);
            this.dptDateTimeTo.TabIndex = 16;
            // 
            // dgvData2
            // 
            this.dgvData2.AllowUserToAddRows = false;
            this.dgvData2.AllowUserToDeleteRows = false;
            this.dgvData2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData2.BackgroundColor = System.Drawing.Color.White;
            this.dgvData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData2.Location = new System.Drawing.Point(835, 72);
            this.dgvData2.Name = "dgvData2";
            this.dgvData2.ReadOnly = true;
            this.dgvData2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData2.Size = new System.Drawing.Size(267, 266);
            this.dgvData2.TabIndex = 6;
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1114, 385);
            this.Controls.Add(this.dptDateTimeTo);
            this.Controls.Add(this.dptDateTimeFrom);
            this.Controls.Add(this.chkDatetime);
            this.Controls.Add(this.txtTextInt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProductCount);
            this.Controls.Add(this.lablel1);
            this.Controls.Add(this.dgvData2);
            this.Controls.Add(this.dgvData);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DISPLAY PURCHASE DETAILS";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.dgvData2, 0);
            this.Controls.SetChildIndex(this.lablel1, 0);
            this.Controls.SetChildIndex(this.lblProductCount, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.lblQuantity, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtTextInt, 0);
            this.Controls.SetChildIndex(this.chkDatetime, 0);
            this.Controls.SetChildIndex(this.dptDateTimeFrom, 0);
            this.Controls.SetChildIndex(this.dptDateTimeTo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lablel1;
        private System.Windows.Forms.Label lblProductCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblQuantity;
        private MyControls.clsMyGrid dgvData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MyControls.ucText txtTextInt;
        private System.Windows.Forms.CheckBox chkDatetime;
        public System.Windows.Forms.DateTimePicker dptDateTimeFrom;
        public System.Windows.Forms.DateTimePicker dptDateTimeTo;
        private MyControls.clsMyGrid dgvData2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
    }
}
