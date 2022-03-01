
namespace Inventory_Management_System
{
    partial class AddModifyPart
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
            this.lblAddModifyPart = new System.Windows.Forms.Label();
            this.rdoBtnAddPartInhouse = new System.Windows.Forms.RadioButton();
            this.rdoBtnAddPartOutsourced = new System.Windows.Forms.RadioButton();
            this.lblAddModifyPartID = new System.Windows.Forms.Label();
            this.lblAddModifyPartName = new System.Windows.Forms.Label();
            this.lblAddModifyPartInventory = new System.Windows.Forms.Label();
            this.lblAddModifyPartPrice = new System.Windows.Forms.Label();
            this.lblAddModifyPartMax = new System.Windows.Forms.Label();
            this.lblAddModifyPartMin = new System.Windows.Forms.Label();
            this.lblAddModifyPartMachineOrCompanyID = new System.Windows.Forms.Label();
            this.txtAddModifyPartID = new System.Windows.Forms.TextBox();
            this.txtAddModifyPartCompanyOrMachineID = new System.Windows.Forms.TextBox();
            this.txtAddModifyPartMin = new System.Windows.Forms.TextBox();
            this.txtAddModifyPartMax = new System.Windows.Forms.TextBox();
            this.txtAddModifyPartPriceCost = new System.Windows.Forms.TextBox();
            this.txtAddModifyPartInventory = new System.Windows.Forms.TextBox();
            this.txtAddModifyPartName = new System.Windows.Forms.TextBox();
            this.btnAddModifyCancelAddPart = new System.Windows.Forms.Button();
            this.btnAddModifySavePart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddModifyPart
            // 
            this.lblAddModifyPart.AutoSize = true;
            this.lblAddModifyPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddModifyPart.Location = new System.Drawing.Point(12, 9);
            this.lblAddModifyPart.Name = "lblAddModifyPart";
            this.lblAddModifyPart.Size = new System.Drawing.Size(82, 20);
            this.lblAddModifyPart.TabIndex = 0;
            this.lblAddModifyPart.Text = "Add Part";
            // 
            // rdoBtnAddPartInhouse
            // 
            this.rdoBtnAddPartInhouse.AutoSize = true;
            this.rdoBtnAddPartInhouse.Location = new System.Drawing.Point(166, 9);
            this.rdoBtnAddPartInhouse.Name = "rdoBtnAddPartInhouse";
            this.rdoBtnAddPartInhouse.Size = new System.Drawing.Size(86, 21);
            this.rdoBtnAddPartInhouse.TabIndex = 0;
            this.rdoBtnAddPartInhouse.TabStop = true;
            this.rdoBtnAddPartInhouse.Text = "In-House";
            this.rdoBtnAddPartInhouse.UseVisualStyleBackColor = true;
            this.rdoBtnAddPartInhouse.CheckedChanged += new System.EventHandler(this.RdoBtnAddPartInhouse_CheckedChanged);
            // 
            // rdoBtnAddPartOutsourced
            // 
            this.rdoBtnAddPartOutsourced.AutoSize = true;
            this.rdoBtnAddPartOutsourced.Location = new System.Drawing.Point(268, 8);
            this.rdoBtnAddPartOutsourced.Name = "rdoBtnAddPartOutsourced";
            this.rdoBtnAddPartOutsourced.Size = new System.Drawing.Size(103, 21);
            this.rdoBtnAddPartOutsourced.TabIndex = 1;
            this.rdoBtnAddPartOutsourced.TabStop = true;
            this.rdoBtnAddPartOutsourced.Text = "Outsourced";
            this.rdoBtnAddPartOutsourced.UseVisualStyleBackColor = true;
            // 
            // lblAddModifyPartID
            // 
            this.lblAddModifyPartID.AutoSize = true;
            this.lblAddModifyPartID.Location = new System.Drawing.Point(105, 83);
            this.lblAddModifyPartID.Name = "lblAddModifyPartID";
            this.lblAddModifyPartID.Size = new System.Drawing.Size(21, 17);
            this.lblAddModifyPartID.TabIndex = 6;
            this.lblAddModifyPartID.Text = "ID";
            // 
            // lblAddModifyPartName
            // 
            this.lblAddModifyPartName.AutoSize = true;
            this.lblAddModifyPartName.Location = new System.Drawing.Point(81, 122);
            this.lblAddModifyPartName.Name = "lblAddModifyPartName";
            this.lblAddModifyPartName.Size = new System.Drawing.Size(45, 17);
            this.lblAddModifyPartName.TabIndex = 7;
            this.lblAddModifyPartName.Text = "Name";
            // 
            // lblAddModifyPartInventory
            // 
            this.lblAddModifyPartInventory.AutoSize = true;
            this.lblAddModifyPartInventory.Location = new System.Drawing.Point(60, 162);
            this.lblAddModifyPartInventory.Name = "lblAddModifyPartInventory";
            this.lblAddModifyPartInventory.Size = new System.Drawing.Size(66, 17);
            this.lblAddModifyPartInventory.TabIndex = 8;
            this.lblAddModifyPartInventory.Text = "Inventory";
            // 
            // lblAddModifyPartPrice
            // 
            this.lblAddModifyPartPrice.AutoSize = true;
            this.lblAddModifyPartPrice.Location = new System.Drawing.Point(54, 201);
            this.lblAddModifyPartPrice.Name = "lblAddModifyPartPrice";
            this.lblAddModifyPartPrice.Size = new System.Drawing.Size(72, 17);
            this.lblAddModifyPartPrice.TabIndex = 9;
            this.lblAddModifyPartPrice.Text = "Price/Cost";
            // 
            // lblAddModifyPartMax
            // 
            this.lblAddModifyPartMax.AutoSize = true;
            this.lblAddModifyPartMax.Location = new System.Drawing.Point(93, 239);
            this.lblAddModifyPartMax.Name = "lblAddModifyPartMax";
            this.lblAddModifyPartMax.Size = new System.Drawing.Size(33, 17);
            this.lblAddModifyPartMax.TabIndex = 10;
            this.lblAddModifyPartMax.Text = "Max";
            // 
            // lblAddModifyPartMin
            // 
            this.lblAddModifyPartMin.AutoSize = true;
            this.lblAddModifyPartMin.Location = new System.Drawing.Point(222, 239);
            this.lblAddModifyPartMin.Name = "lblAddModifyPartMin";
            this.lblAddModifyPartMin.Size = new System.Drawing.Size(30, 17);
            this.lblAddModifyPartMin.TabIndex = 11;
            this.lblAddModifyPartMin.Text = "Min";
            // 
            // lblAddModifyPartMachineOrCompanyID
            // 
            this.lblAddModifyPartMachineOrCompanyID.AutoSize = true;
            this.lblAddModifyPartMachineOrCompanyID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAddModifyPartMachineOrCompanyID.Location = new System.Drawing.Point(47, 276);
            this.lblAddModifyPartMachineOrCompanyID.Name = "lblAddModifyPartMachineOrCompanyID";
            this.lblAddModifyPartMachineOrCompanyID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAddModifyPartMachineOrCompanyID.Size = new System.Drawing.Size(82, 17);
            this.lblAddModifyPartMachineOrCompanyID.TabIndex = 12;
            this.lblAddModifyPartMachineOrCompanyID.Text = "placeholder";
            // 
            // txtAddModifyPartID
            // 
            this.txtAddModifyPartID.Location = new System.Drawing.Point(132, 80);
            this.txtAddModifyPartID.Name = "txtAddModifyPartID";
            this.txtAddModifyPartID.Size = new System.Drawing.Size(100, 22);
            this.txtAddModifyPartID.TabIndex = 50;
            this.txtAddModifyPartID.TextChanged += new System.EventHandler(this.TxtAddModifyPartID_TextChanged);
            // 
            // txtAddModifyPartCompanyOrMachineID
            // 
            this.txtAddModifyPartCompanyOrMachineID.Location = new System.Drawing.Point(132, 273);
            this.txtAddModifyPartCompanyOrMachineID.Name = "txtAddModifyPartCompanyOrMachineID";
            this.txtAddModifyPartCompanyOrMachineID.Size = new System.Drawing.Size(100, 22);
            this.txtAddModifyPartCompanyOrMachineID.TabIndex = 7;
            this.txtAddModifyPartCompanyOrMachineID.TextChanged += new System.EventHandler(this.TxtAddModifyPartCompanyOrMachineID_TextChanged);
            // 
            // txtAddModifyPartMin
            // 
            this.txtAddModifyPartMin.Location = new System.Drawing.Point(258, 238);
            this.txtAddModifyPartMin.Name = "txtAddModifyPartMin";
            this.txtAddModifyPartMin.Size = new System.Drawing.Size(65, 22);
            this.txtAddModifyPartMin.TabIndex = 6;
            this.txtAddModifyPartMin.TextChanged += new System.EventHandler(this.TxtAddModifyPartMin_TextChanged);
            // 
            // txtAddModifyPartMax
            // 
            this.txtAddModifyPartMax.Location = new System.Drawing.Point(132, 236);
            this.txtAddModifyPartMax.Name = "txtAddModifyPartMax";
            this.txtAddModifyPartMax.Size = new System.Drawing.Size(65, 22);
            this.txtAddModifyPartMax.TabIndex = 5;
            this.txtAddModifyPartMax.TextChanged += new System.EventHandler(this.TxtAddModifyPartMax_TextChanged);
            // 
            // txtAddModifyPartPriceCost
            // 
            this.txtAddModifyPartPriceCost.Location = new System.Drawing.Point(132, 198);
            this.txtAddModifyPartPriceCost.Name = "txtAddModifyPartPriceCost";
            this.txtAddModifyPartPriceCost.Size = new System.Drawing.Size(100, 22);
            this.txtAddModifyPartPriceCost.TabIndex = 4;
            this.txtAddModifyPartPriceCost.TextChanged += new System.EventHandler(this.TxtAddModifyPartPriceCost_TextChanged);
            // 
            // txtAddModifyPartInventory
            // 
            this.txtAddModifyPartInventory.Location = new System.Drawing.Point(132, 159);
            this.txtAddModifyPartInventory.Name = "txtAddModifyPartInventory";
            this.txtAddModifyPartInventory.Size = new System.Drawing.Size(100, 22);
            this.txtAddModifyPartInventory.TabIndex = 3;
            this.txtAddModifyPartInventory.TextChanged += new System.EventHandler(this.TxtAddModifyPartInventory_TextChanged);
            // 
            // txtAddModifyPartName
            // 
            this.txtAddModifyPartName.Location = new System.Drawing.Point(132, 119);
            this.txtAddModifyPartName.Name = "txtAddModifyPartName";
            this.txtAddModifyPartName.Size = new System.Drawing.Size(100, 22);
            this.txtAddModifyPartName.TabIndex = 2;
            this.txtAddModifyPartName.TextChanged += new System.EventHandler(this.TxtAddModifyPartName_TextChanged);
            // 
            // btnAddModifyCancelAddPart
            // 
            this.btnAddModifyCancelAddPart.Location = new System.Drawing.Point(296, 333);
            this.btnAddModifyCancelAddPart.Name = "btnAddModifyCancelAddPart";
            this.btnAddModifyCancelAddPart.Size = new System.Drawing.Size(75, 23);
            this.btnAddModifyCancelAddPart.TabIndex = 9;
            this.btnAddModifyCancelAddPart.Text = "Cancel";
            this.btnAddModifyCancelAddPart.UseVisualStyleBackColor = true;
            this.btnAddModifyCancelAddPart.Click += new System.EventHandler(this.BtnAddModifyCancelAddPart_Click);
            // 
            // btnAddModifySavePart
            // 
            this.btnAddModifySavePart.Location = new System.Drawing.Point(215, 333);
            this.btnAddModifySavePart.Name = "btnAddModifySavePart";
            this.btnAddModifySavePart.Size = new System.Drawing.Size(75, 23);
            this.btnAddModifySavePart.TabIndex = 8;
            this.btnAddModifySavePart.Text = "Save";
            this.btnAddModifySavePart.UseVisualStyleBackColor = true;
            this.btnAddModifySavePart.Click += new System.EventHandler(this.BtnAddModifySavePart_Click);
            // 
            // AddModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 368);
            this.Controls.Add(this.btnAddModifyCancelAddPart);
            this.Controls.Add(this.btnAddModifySavePart);
            this.Controls.Add(this.txtAddModifyPartName);
            this.Controls.Add(this.txtAddModifyPartInventory);
            this.Controls.Add(this.txtAddModifyPartPriceCost);
            this.Controls.Add(this.txtAddModifyPartMax);
            this.Controls.Add(this.txtAddModifyPartMin);
            this.Controls.Add(this.txtAddModifyPartCompanyOrMachineID);
            this.Controls.Add(this.txtAddModifyPartID);
            this.Controls.Add(this.lblAddModifyPartMachineOrCompanyID);
            this.Controls.Add(this.lblAddModifyPartMin);
            this.Controls.Add(this.lblAddModifyPartMax);
            this.Controls.Add(this.lblAddModifyPartPrice);
            this.Controls.Add(this.lblAddModifyPartInventory);
            this.Controls.Add(this.lblAddModifyPartName);
            this.Controls.Add(this.lblAddModifyPartID);
            this.Controls.Add(this.rdoBtnAddPartOutsourced);
            this.Controls.Add(this.rdoBtnAddPartInhouse);
            this.Controls.Add(this.lblAddModifyPart);
            this.Name = "AddModifyPart";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddModifyPart;
        private System.Windows.Forms.RadioButton rdoBtnAddPartInhouse;
        private System.Windows.Forms.RadioButton rdoBtnAddPartOutsourced;
        private System.Windows.Forms.Label lblAddModifyPartID;
        private System.Windows.Forms.Label lblAddModifyPartName;
        private System.Windows.Forms.Label lblAddModifyPartInventory;
        private System.Windows.Forms.Label lblAddModifyPartPrice;
        private System.Windows.Forms.Label lblAddModifyPartMax;
        private System.Windows.Forms.Label lblAddModifyPartMin;
        private System.Windows.Forms.Label lblAddModifyPartMachineOrCompanyID;
        private System.Windows.Forms.TextBox txtAddModifyPartID;
        private System.Windows.Forms.TextBox txtAddModifyPartCompanyOrMachineID;
        private System.Windows.Forms.TextBox txtAddModifyPartMin;
        private System.Windows.Forms.TextBox txtAddModifyPartMax;
        private System.Windows.Forms.TextBox txtAddModifyPartPriceCost;
        private System.Windows.Forms.TextBox txtAddModifyPartInventory;
        private System.Windows.Forms.TextBox txtAddModifyPartName;
        private System.Windows.Forms.Button btnAddModifyCancelAddPart;
        private System.Windows.Forms.Button btnAddModifySavePart;
    }
}