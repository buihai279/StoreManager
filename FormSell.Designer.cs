namespace StoreManager
{
    partial class fSell
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
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvListProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFielPrice = new System.Windows.Forms.Label();
            this.lblFielQuality = new System.Windows.Forms.Label();
            this.lblFielName = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.btnChekout = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(0, 3);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(221, 20);
            this.txtProductId.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(244, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvListProduct);
            this.splitContainer1.Panel1.Controls.Add(this.txtProductId);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.lblFielPrice);
            this.splitContainer1.Panel2.Controls.Add(this.lblFielQuality);
            this.splitContainer1.Panel2.Controls.Add(this.lblFielName);
            this.splitContainer1.Panel2.Controls.Add(this.lblOrder);
            this.splitContainer1.Panel2.Controls.Add(this.btnChekout);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer1.Size = new System.Drawing.Size(928, 378);
            this.splitContainer1.SplitterDistance = 460;
            this.splitContainer1.TabIndex = 2;
            // 
            // dgvListProduct
            // 
            this.dgvListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProduct.Location = new System.Drawing.Point(3, 32);
            this.dgvListProduct.Name = "dgvListProduct";
            this.dgvListProduct.Size = new System.Drawing.Size(412, 343);
            this.dgvListProduct.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã / Thẻ giảm giá";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 311);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(46, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblFielPrice
            // 
            this.lblFielPrice.AutoSize = true;
            this.lblFielPrice.Location = new System.Drawing.Point(358, 32);
            this.lblFielPrice.Name = "lblFielPrice";
            this.lblFielPrice.Size = new System.Drawing.Size(44, 13);
            this.lblFielPrice.TabIndex = 3;
            this.lblFielPrice.Text = "Đơn giá";
            // 
            // lblFielQuality
            // 
            this.lblFielQuality.AutoSize = true;
            this.lblFielQuality.Location = new System.Drawing.Point(270, 32);
            this.lblFielQuality.Name = "lblFielQuality";
            this.lblFielQuality.Size = new System.Drawing.Size(49, 13);
            this.lblFielQuality.TabIndex = 3;
            this.lblFielQuality.Text = "Số lượng";
            // 
            // lblFielName
            // 
            this.lblFielName.AutoSize = true;
            this.lblFielName.Location = new System.Drawing.Point(43, 32);
            this.lblFielName.Name = "lblFielName";
            this.lblFielName.Size = new System.Drawing.Size(75, 13);
            this.lblFielName.TabIndex = 3;
            this.lblFielName.Text = "Tên sản phẩm";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(192, 3);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(54, 13);
            this.lblOrder.TabIndex = 2;
            this.lblOrder.Text = "Đơn hàng";
            // 
            // btnChekout
            // 
            this.btnChekout.Location = new System.Drawing.Point(88, 355);
            this.btnChekout.Name = "btnChekout";
            this.btnChekout.Size = new System.Drawing.Size(75, 23);
            this.btnChekout.TabIndex = 1;
            this.btnChekout.Text = "Thanh toán";
            this.btnChekout.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(257, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // fSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 402);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fSell";
            this.Text = "FormSell";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvListProduct;
        private System.Windows.Forms.Button btnChekout;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFielPrice;
        private System.Windows.Forms.Label lblFielQuality;
        private System.Windows.Forms.Label lblFielName;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}