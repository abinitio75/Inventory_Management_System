
namespace Inventory_Management_System
{
    partial class MainScreen
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.btnModifyPart = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblIMS = new System.Windows.Forms.Label();
            this.lblParts = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.txtSearchParts = new System.Windows.Forms.TextBox();
            this.txtSearchProducts = new System.Windows.Forms.TextBox();
            this.btnSearchProducts = new System.Windows.Forms.Button();
            this.btnSearchParts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(995, 386);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(995, 333);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduct.TabIndex = 11;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Location = new System.Drawing.Point(914, 333);
            this.btnModifyProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(75, 23);
            this.btnModifyProduct.TabIndex = 10;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            this.btnModifyProduct.Click += new System.EventHandler(this.BtnModifyProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(833, 333);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 9;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Location = new System.Drawing.Point(440, 333);
            this.btnDeletePart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePart.TabIndex = 5;
            this.btnDeletePart.Text = "Delete";
            this.btnDeletePart.UseVisualStyleBackColor = true;
            this.btnDeletePart.Click += new System.EventHandler(this.BtnDeletePart_Click);
            // 
            // btnModifyPart
            // 
            this.btnModifyPart.Location = new System.Drawing.Point(359, 333);
            this.btnModifyPart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifyPart.Name = "btnModifyPart";
            this.btnModifyPart.Size = new System.Drawing.Size(75, 23);
            this.btnModifyPart.TabIndex = 4;
            this.btnModifyPart.Text = "Modify";
            this.btnModifyPart.UseVisualStyleBackColor = true;
            this.btnModifyPart.Click += new System.EventHandler(this.BtnModifyPart_Click);
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(278, 333);
            this.btnAddPart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(75, 23);
            this.btnAddPart.TabIndex = 3;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.BtnAddPart_Click);
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.AllowUserToDeleteRows = false;
            this.dgvParts.AllowUserToResizeColumns = false;
            this.dgvParts.AllowUserToResizeRows = false;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvParts.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvParts.Location = new System.Drawing.Point(17, 127);
            this.dgvParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvParts.MultiSelect = false;
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.RowHeadersVisible = false;
            this.dgvParts.RowHeadersWidth = 51;
            this.dgvParts.RowTemplate.Height = 24;
            this.dgvParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParts.Size = new System.Drawing.Size(498, 202);
            this.dgvParts.StandardTab = true;
            this.dgvParts.TabIndex = 2;
            this.dgvParts.TabStop = false;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProducts.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvProducts.Location = new System.Drawing.Point(557, 127);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(513, 202);
            this.dgvProducts.StandardTab = true;
            this.dgvProducts.TabIndex = 8;
            this.dgvProducts.TabStop = false;
            // 
            // lblIMS
            // 
            this.lblIMS.AutoSize = true;
            this.lblIMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMS.Location = new System.Drawing.Point(12, 9);
            this.lblIMS.Name = "lblIMS";
            this.lblIMS.Size = new System.Drawing.Size(310, 25);
            this.lblIMS.TabIndex = 50;
            this.lblIMS.Text = "Inventory Management System";
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParts.Location = new System.Drawing.Point(12, 96);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(57, 25);
            this.lblParts.TabIndex = 50;
            this.lblParts.Text = "Parts";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(552, 98);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(89, 25);
            this.lblProducts.TabIndex = 50;
            this.lblProducts.Text = "Products";
            // 
            // txtSearchParts
            // 
            this.txtSearchParts.Location = new System.Drawing.Point(348, 100);
            this.txtSearchParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchParts.Name = "txtSearchParts";
            this.txtSearchParts.Size = new System.Drawing.Size(167, 22);
            this.txtSearchParts.TabIndex = 0;
            // 
            // txtSearchProducts
            // 
            this.txtSearchProducts.Location = new System.Drawing.Point(903, 99);
            this.txtSearchProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchProducts.Name = "txtSearchProducts";
            this.txtSearchProducts.Size = new System.Drawing.Size(167, 22);
            this.txtSearchProducts.TabIndex = 6;
            // 
            // btnSearchProducts
            // 
            this.btnSearchProducts.Location = new System.Drawing.Point(822, 99);
            this.btnSearchProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchProducts.Name = "btnSearchProducts";
            this.btnSearchProducts.Size = new System.Drawing.Size(75, 23);
            this.btnSearchProducts.TabIndex = 7;
            this.btnSearchProducts.Text = "Search";
            this.btnSearchProducts.UseVisualStyleBackColor = true;
            this.btnSearchProducts.Click += new System.EventHandler(this.BtnSearchProducts_Click);
            // 
            // btnSearchParts
            // 
            this.btnSearchParts.Location = new System.Drawing.Point(267, 100);
            this.btnSearchParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchParts.Name = "btnSearchParts";
            this.btnSearchParts.Size = new System.Drawing.Size(75, 23);
            this.btnSearchParts.TabIndex = 1;
            this.btnSearchParts.Text = "Search";
            this.btnSearchParts.UseVisualStyleBackColor = true;
            this.btnSearchParts.Click += new System.EventHandler(this.BtnSearchParts_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 420);
            this.Controls.Add(this.btnSearchParts);
            this.Controls.Add(this.btnSearchProducts);
            this.Controls.Add(this.txtSearchProducts);
            this.Controls.Add(this.txtSearchParts);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblParts);
            this.Controls.Add(this.lblIMS);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.btnModifyPart);
            this.Controls.Add(this.btnDeletePart);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnModifyProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.Button btnModifyPart;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblIMS;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.TextBox txtSearchParts;
        private System.Windows.Forms.TextBox txtSearchProducts;
        private System.Windows.Forms.Button btnSearchProducts;
        private System.Windows.Forms.Button btnSearchParts;
    }
}

