namespace IUBAT_Pharmacy.Presentation.MyControls
{
    partial class ucImage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.llClear = new System.Windows.Forms.LinkLabel();
            this.llBrowse = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.Location = new System.Drawing.Point(-1, 22);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(279, 248);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLabel.Location = new System.Drawing.Point(0, 0);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(36, 13);
            this.lblLabel.TabIndex = 1;
            this.lblLabel.Text = "Image";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(278, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 2;
            // 
            // llClear
            // 
            this.llClear.AutoSize = true;
            this.llClear.Location = new System.Drawing.Point(51, 273);
            this.llClear.Name = "llClear";
            this.llClear.Size = new System.Drawing.Size(31, 13);
            this.llClear.TabIndex = 5;
            this.llClear.TabStop = true;
            this.llClear.Text = "Clear";
            this.llClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClear_LinkClicked_1);
            // 
            // llBrowse
            // 
            this.llBrowse.AutoSize = true;
            this.llBrowse.Location = new System.Drawing.Point(3, 273);
            this.llBrowse.Name = "llBrowse";
            this.llBrowse.Size = new System.Drawing.Size(42, 13);
            this.llBrowse.TabIndex = 5;
            this.llBrowse.TabStop = true;
            this.llBrowse.Text = "Browse";
            this.llBrowse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llBrowse_LinkClicked_1);
            // 
            // ucImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.llBrowse);
            this.Controls.Add(this.llClear);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.pbImage);
            this.Name = "ucImage";
            this.Size = new System.Drawing.Size(278, 289);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbImage;
        public System.Windows.Forms.Label lblLabel;
        public System.Windows.Forms.Label lblError;
        public System.Windows.Forms.LinkLabel llClear;
        public System.Windows.Forms.LinkLabel llBrowse;

    }
}
