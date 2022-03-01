
namespace Inventory_Management_System
{
    partial class AddModifyProduct
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
            this.txtAddModifyProductSearchParts = new System.Windows.Forms.TextBox();
            this.lblAddModifyProduct = new System.Windows.Forms.Label();
            this.lblAddModifyProductAllParts = new System.Windows.Forms.Label();
            this.lblAddModifyProductAssociatedParts = new System.Windows.Forms.Label();
            this.txtAddModifyProductName = new System.Windows.Forms.TextBox();
            this.txtAddModifyProductInventory = new System.Windows.Forms.TextBox();
            this.txtAddModifyProductPriceCost = new System.Windows.Forms.TextBox();
            this.txtAddModifyProductMax = new System.Windows.Forms.TextBox();
            this.txtAddModifyProductMin = new System.Windows.Forms.TextBox();
            this.txtAddModifyProductID = new System.Windows.Forms.TextBox();
            this.lblAddModifyProductMin = new System.Windows.Forms.Label();
            this.lblAddModifyProductMax = new System.Windows.Forms.Label();
            this.lblAddModifyProductPrice = new System.Windows.Forms.Label();
            this.lblAddModifyProductInventory = new System.Windows.Forms.Label();
            this.lblAddModifyProductName = new System.Windows.Forms.Label();
            this.lblAddModifyProductID = new System.Windows.Forms.Label();
            this.btnAddModifyProductSearchCandidateParts = new System.Windows.Forms.Button();
            this.btnAddModifyProductAdd = new System.Windows.Forms.Button();
            this.btnAddModifyProductDelete = new System.Windows.Forms.Button();
            this.btnAddModifyProductSave = new System.Windows.Forms.Button();
            this.btnAddModifyProductCancel = new System.Windows.Forms.Button();
            this.dgvAllParts = new System.Windows.Forms.DataGridView();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddModifyProductSearchParts
            // 
            this.txtAddModifyProductSearchParts.Location = new System.Drawing.Point(781, 20);
            this.txtAddModifyProductSearchParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddModifyProductSearchParts.Name = "txtAddModifyProductSearchParts";
            this.txtAddModifyProductSearchParts.Size = new System.Drawing.Size(156, 22);
            this.txtAddModifyProductSearchParts.TabIndex = 5;
            // 
            // lblAddModifyProduct
            // 
            this.lblAddModifyProduct.AutoSize = true;
            this.lblAddModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddModifyProduct.Location = new System.Drawing.Point(12, 9);
            this.lblAddModifyProduct.Name = "lblAddModifyProduct";
            this.lblAddModifyProduct.Size = new System.Drawing.Size(120, 25);
            this.lblAddModifyProduct.TabIndex = 7;
            this.lblAddModifyProduct.Text = "Add Product";
            // 
            // lblAddModifyProductAllParts
            // 
            this.lblAddModifyProductAllParts.AutoSize = true;
            this.lblAddModifyProductAllParts.Location = new System.Drawing.Point(437, 25);
            this.lblAddModifyProductAllParts.Name = "lblAddModifyProductAllParts";
            this.lblAddModifyProductAllParts.Size = new System.Drawing.Size(128, 17);
            this.lblAddModifyProductAllParts.TabIndex = 14;
            this.lblAddModifyProductAllParts.Text = "All Candidate Parts";
            // 
            // lblAddModifyProductAssociatedParts
            // 
            this.lblAddModifyProductAssociatedParts.AutoSize = true;
            this.lblAddModifyProductAssociatedParts.Location = new System.Drawing.Point(437, 266);
            this.lblAddModifyProductAssociatedParts.Name = "lblAddModifyProductAssociatedParts";
            this.lblAddModifyProductAssociatedParts.Size = new System.Drawing.Size(221, 17);
            this.lblAddModifyProductAssociatedParts.TabIndex = 15;
            this.lblAddModifyProductAssociatedParts.Text = "Parts Associated with this Product";
            // 
            // txtAddModifyProductName
            // 
            this.txtAddModifyProductName.Location = new System.Drawing.Point(147, 194);
            this.txtAddModifyProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddModifyProductName.Name = "txtAddModifyProductName";
            this.txtAddModifyProductName.Size = new System.Drawing.Size(100, 22);
            this.txtAddModifyProductName.TabIndex = 0;
            this.txtAddModifyProductName.TextChanged += new System.EventHandler(this.TxtAddModifyProductName_TextChanged);
            // 
            // txtAddModifyProductInventory
            // 
            this.txtAddModifyProductInventory.Location = new System.Drawing.Point(147, 234);
            this.txtAddModifyProductInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddModifyProductInventory.Name = "txtAddModifyProductInventory";
            this.txtAddModifyProductInventory.Size = new System.Drawing.Size(100, 22);
            this.txtAddModifyProductInventory.TabIndex = 1;
            this.txtAddModifyProductInventory.TextChanged += new System.EventHandler(this.TxtAddModifyProductInventory_TextChanged);
            // 
            // txtAddModifyProductPriceCost
            // 
            this.txtAddModifyProductPriceCost.Location = new System.Drawing.Point(147, 273);
            this.txtAddModifyProductPriceCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddModifyProductPriceCost.Name = "txtAddModifyProductPriceCost";
            this.txtAddModifyProductPriceCost.Size = new System.Drawing.Size(100, 22);
            this.txtAddModifyProductPriceCost.TabIndex = 2;
            this.txtAddModifyProductPriceCost.TextChanged += new System.EventHandler(this.TxtAddModifyProductPriceCost_TextChanged);
            // 
            // txtAddModifyProductMax
            // 
            this.txtAddModifyProductMax.Location = new System.Drawing.Point(147, 311);
            this.txtAddModifyProductMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddModifyProductMax.Name = "txtAddModifyProductMax";
            this.txtAddModifyProductMax.Size = new System.Drawing.Size(65, 22);
            this.txtAddModifyProductMax.TabIndex = 3;
            this.txtAddModifyProductMax.TextChanged += new System.EventHandler(this.TxtAddModifyProductMax_TextChanged);
            // 
            // txtAddModifyProductMin
            // 
            this.txtAddModifyProductMin.Location = new System.Drawing.Point(272, 313);
            this.txtAddModifyProductMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddModifyProductMin.Name = "txtAddModifyProductMin";
            this.txtAddModifyProductMin.Size = new System.Drawing.Size(65, 22);
            this.txtAddModifyProductMin.TabIndex = 4;
            this.txtAddModifyProductMin.TextChanged += new System.EventHandler(this.TxtAddModifyProductMin_TextChanged);
            // 
            // txtAddModifyProductID
            // 
            this.txtAddModifyProductID.Location = new System.Drawing.Point(147, 155);
            this.txtAddModifyProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddModifyProductID.Name = "txtAddModifyProductID";
            this.txtAddModifyProductID.Size = new System.Drawing.Size(100, 22);
            this.txtAddModifyProductID.TabIndex = 50;
            this.txtAddModifyProductID.TextChanged += new System.EventHandler(this.TxtAddModifyProductID_TextChanged);
            // 
            // lblAddModifyProductMin
            // 
            this.lblAddModifyProductMin.AutoSize = true;
            this.lblAddModifyProductMin.Location = new System.Drawing.Point(236, 314);
            this.lblAddModifyProductMin.Name = "lblAddModifyProductMin";
            this.lblAddModifyProductMin.Size = new System.Drawing.Size(30, 17);
            this.lblAddModifyProductMin.TabIndex = 32;
            this.lblAddModifyProductMin.Text = "Min";
            // 
            // lblAddModifyProductMax
            // 
            this.lblAddModifyProductMax.AutoSize = true;
            this.lblAddModifyProductMax.Location = new System.Drawing.Point(107, 314);
            this.lblAddModifyProductMax.Name = "lblAddModifyProductMax";
            this.lblAddModifyProductMax.Size = new System.Drawing.Size(33, 17);
            this.lblAddModifyProductMax.TabIndex = 31;
            this.lblAddModifyProductMax.Text = "Max";
            // 
            // lblAddModifyProductPrice
            // 
            this.lblAddModifyProductPrice.AutoSize = true;
            this.lblAddModifyProductPrice.Location = new System.Drawing.Point(68, 276);
            this.lblAddModifyProductPrice.Name = "lblAddModifyProductPrice";
            this.lblAddModifyProductPrice.Size = new System.Drawing.Size(72, 17);
            this.lblAddModifyProductPrice.TabIndex = 30;
            this.lblAddModifyProductPrice.Text = "Price/Cost";
            // 
            // lblAddModifyProductInventory
            // 
            this.lblAddModifyProductInventory.AutoSize = true;
            this.lblAddModifyProductInventory.Location = new System.Drawing.Point(75, 238);
            this.lblAddModifyProductInventory.Name = "lblAddModifyProductInventory";
            this.lblAddModifyProductInventory.Size = new System.Drawing.Size(66, 17);
            this.lblAddModifyProductInventory.TabIndex = 29;
            this.lblAddModifyProductInventory.Text = "Inventory";
            // 
            // lblAddModifyProductName
            // 
            this.lblAddModifyProductName.AutoSize = true;
            this.lblAddModifyProductName.Location = new System.Drawing.Point(95, 197);
            this.lblAddModifyProductName.Name = "lblAddModifyProductName";
            this.lblAddModifyProductName.Size = new System.Drawing.Size(45, 17);
            this.lblAddModifyProductName.TabIndex = 28;
            this.lblAddModifyProductName.Text = "Name";
            // 
            // lblAddModifyProductID
            // 
            this.lblAddModifyProductID.AutoSize = true;
            this.lblAddModifyProductID.Location = new System.Drawing.Point(119, 158);
            this.lblAddModifyProductID.Name = "lblAddModifyProductID";
            this.lblAddModifyProductID.Size = new System.Drawing.Size(21, 17);
            this.lblAddModifyProductID.TabIndex = 27;
            this.lblAddModifyProductID.Text = "ID";
            // 
            // btnAddModifyProductSearchCandidateParts
            // 
            this.btnAddModifyProductSearchCandidateParts.Location = new System.Drawing.Point(700, 18);
            this.btnAddModifyProductSearchCandidateParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddModifyProductSearchCandidateParts.Name = "btnAddModifyProductSearchCandidateParts";
            this.btnAddModifyProductSearchCandidateParts.Size = new System.Drawing.Size(75, 23);
            this.btnAddModifyProductSearchCandidateParts.TabIndex = 6;
            this.btnAddModifyProductSearchCandidateParts.Text = "Search";
            this.btnAddModifyProductSearchCandidateParts.UseVisualStyleBackColor = true;
            this.btnAddModifyProductSearchCandidateParts.Click += new System.EventHandler(this.BtnAddModifyProductSearchCandidateParts_Click);
            // 
            // btnAddModifyProductAdd
            // 
            this.btnAddModifyProductAdd.Location = new System.Drawing.Point(861, 249);
            this.btnAddModifyProductAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddModifyProductAdd.Name = "btnAddModifyProductAdd";
            this.btnAddModifyProductAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAddModifyProductAdd.TabIndex = 8;
            this.btnAddModifyProductAdd.Text = "Add";
            this.btnAddModifyProductAdd.UseVisualStyleBackColor = true;
            this.btnAddModifyProductAdd.Click += new System.EventHandler(this.BtnAddModifyProductAdd_Click);
            // 
            // btnAddModifyProductDelete
            // 
            this.btnAddModifyProductDelete.Location = new System.Drawing.Point(861, 463);
            this.btnAddModifyProductDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddModifyProductDelete.Name = "btnAddModifyProductDelete";
            this.btnAddModifyProductDelete.Size = new System.Drawing.Size(75, 23);
            this.btnAddModifyProductDelete.TabIndex = 10;
            this.btnAddModifyProductDelete.Text = "Delete";
            this.btnAddModifyProductDelete.UseVisualStyleBackColor = true;
            this.btnAddModifyProductDelete.Click += new System.EventHandler(this.BtnAddModifyProductDelete_Click);
            // 
            // btnAddModifyProductSave
            // 
            this.btnAddModifyProductSave.Location = new System.Drawing.Point(780, 506);
            this.btnAddModifyProductSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddModifyProductSave.Name = "btnAddModifyProductSave";
            this.btnAddModifyProductSave.Size = new System.Drawing.Size(75, 23);
            this.btnAddModifyProductSave.TabIndex = 11;
            this.btnAddModifyProductSave.Text = "Save";
            this.btnAddModifyProductSave.UseVisualStyleBackColor = true;
            this.btnAddModifyProductSave.Click += new System.EventHandler(this.BtnAddModifyProductSave_Click);
            // 
            // btnAddModifyProductCancel
            // 
            this.btnAddModifyProductCancel.Location = new System.Drawing.Point(861, 506);
            this.btnAddModifyProductCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddModifyProductCancel.Name = "btnAddModifyProductCancel";
            this.btnAddModifyProductCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddModifyProductCancel.TabIndex = 12;
            this.btnAddModifyProductCancel.Text = "Cancel";
            this.btnAddModifyProductCancel.UseVisualStyleBackColor = true;
            this.btnAddModifyProductCancel.Click += new System.EventHandler(this.BtnAddModifyProductCancel_Click);
            // 
            // dgvAllParts
            // 
            this.dgvAllParts.AllowUserToAddRows = false;
            this.dgvAllParts.AllowUserToDeleteRows = false;
            this.dgvAllParts.AllowUserToResizeColumns = false;
            this.dgvAllParts.AllowUserToResizeRows = false;
            this.dgvAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllParts.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvAllParts.Location = new System.Drawing.Point(440, 48);
            this.dgvAllParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAllParts.MultiSelect = false;
            this.dgvAllParts.Name = "dgvAllParts";
            this.dgvAllParts.ReadOnly = true;
            this.dgvAllParts.RowHeadersVisible = false;
            this.dgvAllParts.RowHeadersWidth = 51;
            this.dgvAllParts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAllParts.RowTemplate.Height = 24;
            this.dgvAllParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllParts.Size = new System.Drawing.Size(497, 180);
            this.dgvAllParts.StandardTab = true;
            this.dgvAllParts.TabIndex = 7;
            this.dgvAllParts.TabStop = false;
            // 
            // dgvAssociatedParts
            // 
            this.dgvAssociatedParts.AllowUserToAddRows = false;
            this.dgvAssociatedParts.AllowUserToDeleteRows = false;
            this.dgvAssociatedParts.AllowUserToResizeColumns = false;
            this.dgvAssociatedParts.AllowUserToResizeRows = false;
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedParts.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(440, 286);
            this.dgvAssociatedParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAssociatedParts.MultiSelect = false;
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.ReadOnly = true;
            this.dgvAssociatedParts.RowHeadersVisible = false;
            this.dgvAssociatedParts.RowHeadersWidth = 51;
            this.dgvAssociatedParts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAssociatedParts.RowTemplate.Height = 24;
            this.dgvAssociatedParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssociatedParts.Size = new System.Drawing.Size(497, 161);
            this.dgvAssociatedParts.StandardTab = true;
            this.dgvAssociatedParts.TabIndex = 9;
            this.dgvAssociatedParts.TabStop = false;
            // 
            // AddModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 542);
            this.Controls.Add(this.dgvAssociatedParts);
            this.Controls.Add(this.dgvAllParts);
            this.Controls.Add(this.btnAddModifyProductCancel);
            this.Controls.Add(this.btnAddModifyProductSave);
            this.Controls.Add(this.btnAddModifyProductDelete);
            this.Controls.Add(this.btnAddModifyProductAdd);
            this.Controls.Add(this.btnAddModifyProductSearchCandidateParts);
            this.Controls.Add(this.txtAddModifyProductName);
            this.Controls.Add(this.txtAddModifyProductInventory);
            this.Controls.Add(this.txtAddModifyProductPriceCost);
            this.Controls.Add(this.txtAddModifyProductMax);
            this.Controls.Add(this.txtAddModifyProductMin);
            this.Controls.Add(this.txtAddModifyProductID);
            this.Controls.Add(this.lblAddModifyProductMin);
            this.Controls.Add(this.lblAddModifyProductMax);
            this.Controls.Add(this.lblAddModifyProductPrice);
            this.Controls.Add(this.lblAddModifyProductInventory);
            this.Controls.Add(this.lblAddModifyProductName);
            this.Controls.Add(this.lblAddModifyProductID);
            this.Controls.Add(this.lblAddModifyProductAssociatedParts);
            this.Controls.Add(this.lblAddModifyProductAllParts);
            this.Controls.Add(this.lblAddModifyProduct);
            this.Controls.Add(this.txtAddModifyProductSearchParts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddModifyProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.AddModifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAddModifyProductSearchParts;
        private System.Windows.Forms.Label lblAddModifyProduct;
        private System.Windows.Forms.Label lblAddModifyProductAllParts;
        private System.Windows.Forms.Label lblAddModifyProductAssociatedParts;
        private System.Windows.Forms.TextBox txtAddModifyProductName;
        private System.Windows.Forms.TextBox txtAddModifyProductInventory;
        private System.Windows.Forms.TextBox txtAddModifyProductPriceCost;
        private System.Windows.Forms.TextBox txtAddModifyProductMax;
        private System.Windows.Forms.TextBox txtAddModifyProductMin;
        private System.Windows.Forms.TextBox txtAddModifyProductID;
        private System.Windows.Forms.Label lblAddModifyProductMin;
        private System.Windows.Forms.Label lblAddModifyProductMax;
        private System.Windows.Forms.Label lblAddModifyProductPrice;
        private System.Windows.Forms.Label lblAddModifyProductInventory;
        private System.Windows.Forms.Label lblAddModifyProductName;
        private System.Windows.Forms.Label lblAddModifyProductID;
        private System.Windows.Forms.Button btnAddModifyProductSearchCandidateParts;
        private System.Windows.Forms.Button btnAddModifyProductAdd;
        private System.Windows.Forms.Button btnAddModifyProductDelete;
        private System.Windows.Forms.Button btnAddModifyProductSave;
        private System.Windows.Forms.Button btnAddModifyProductCancel;
        private System.Windows.Forms.DataGridView dgvAllParts;
        private System.Windows.Forms.DataGridView dgvAssociatedParts;
    }
}