using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Inventory_Management_System
{
    public partial class AddModifyProduct : Form
    {
        bool isNew;
        Product selectedProduct;
        private List<Part> originalAssociation = new List<Part>();
        
        private Dictionary<string, bool> allowSave = new Dictionary<string, bool>()
        {
            {"name", false}, {"inventory", false }, {"price", false }, {"min", false },
            {"max", false }
        };
        
        public AddModifyProduct()
        {
            InitializeComponent();
            isNew = true;
            PopulateScreen(new Product());
        }
        
        public AddModifyProduct(Product product)
        {
            InitializeComponent();
            isNew = false;
            PopulateScreen(product);
        }
        
        private void AddModifyProduct_Load(object sender, EventArgs e)
        {
            dgvAllParts.DataSource = Inventory.AllParts;
            dgvAllParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvAssociatedParts.DataSource = selectedProduct.AssociatedParts;
            dgvAssociatedParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvAllParts.Columns["price"].DefaultCellStyle.Format = "C2";
            dgvAssociatedParts.Columns["price"].DefaultCellStyle.Format = "C2";
        }
        
        private void PopulateScreen(Product product)
        {
            if (isNew)
            {
                txtAddModifyProductID.Text = Inventory.SetID("product").ToString();
                txtAddModifyProductName.BackColor = Color.LightSalmon;
                txtAddModifyProductInventory.BackColor = Color.LightSalmon;
                txtAddModifyProductPriceCost.BackColor = Color.LightSalmon;
                txtAddModifyProductMin.BackColor = Color.LightSalmon;
                txtAddModifyProductMax.BackColor = Color.LightSalmon;
                btnAddModifyProductSave.Enabled = false;
                lblAddModifyProduct.Text = "Add Product";
            }
            else
            {
                txtAddModifyProductID.Text = product.ProductID.ToString();
                txtAddModifyProductName.Text = product.Name;
                txtAddModifyProductInventory.Text = product.InStock.ToString();
                txtAddModifyProductPriceCost.Text = product.Price.ToString();
                txtAddModifyProductMin.Text = product.Min.ToString();
                txtAddModifyProductMax.Text = product.Max.ToString();
                lblAddModifyProduct.Text = "Modify Product";
                GetAssociated(product);
            }
            txtAddModifyProductID.Enabled = false;
            selectedProduct = product;
        }
        
        private void AllowSave(string field, bool value)
        {
            switch (field)
            {
                case "name":
                    allowSave[field] = value;
                    break;
                case "inventory":
                    allowSave[field] = value;
                    break;
                case "price":
                    allowSave[field] = value;
                    break;
                case "min":
                    allowSave[field] = value;
                    break;
                case "max":
                    allowSave[field] = value;
                    break;
                default:
                    break;
            }
            btnAddModifyProductSave.Enabled = !allowSave.ContainsValue(false);
        }
        
        private void GetAssociated(Product product)
        {
            foreach(Part part in product.AssociatedParts)
                originalAssociation.Add(part);
        }
        
        private void BtnAddModifyProductSearchCandidateParts_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAddModifyProductSearchParts.Text))
            {
                Part found;
                if (int.TryParse(txtAddModifyProductSearchParts.Text, out int searchID))
                    found = Inventory.LookupPart(searchID);
                else
                    found = Inventory.LookupPart(txtAddModifyProductSearchParts.Text);
                if (!string.IsNullOrEmpty(found.Name))
                {
                    foreach (DataGridViewRow searchView in dgvAllParts.Rows)
                    {
                        if ((Part)searchView.DataBoundItem == found)
                        {
                            searchView.Selected = true;
                            break;
                        }
                    }
                }
            }
        }
        
        private void TxtAddModifyProductID_TextChanged(object sender, EventArgs e)
        {
            //modification disabled
        }
        
        private void TxtAddModifyProductName_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtAddModifyProductName.Text, "^[a-zA-Z]"))
            {
                txtAddModifyProductName.BackColor = Color.LightSalmon;
                AllowSave("name", false);
            }
            else
            {
                txtAddModifyProductName.BackColor = Color.White;
                AllowSave("name", true);
            }
        }
        
        private void TxtAddModifyProductInventory_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAddModifyProductInventory.Text, out _))
            {
                txtAddModifyProductInventory.BackColor = Color.LightSalmon;
                AllowSave("inventory", false);
            }
            else
            {
                txtAddModifyProductInventory.BackColor = Color.White;
                AllowSave("inventory", true);
            }
        }
        
        private void TxtAddModifyProductPriceCost_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtAddModifyProductPriceCost.Text, "[^$0-9.]"))
            {
                txtAddModifyProductPriceCost.BackColor = Color.LightSalmon;
                AllowSave("price", false);
            }
            else
            {
                txtAddModifyProductPriceCost.BackColor = Color.White;
                AllowSave("price", true);
            }
        }
        
        private void TxtAddModifyProductMax_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAddModifyProductMax.Text, out _))
            {
                txtAddModifyProductMax.BackColor = Color.LightSalmon;
                AllowSave("max", false);
            }
            else
            {
                txtAddModifyProductMax.BackColor = Color.White;
                AllowSave("max", true);
            }
        }
        
        private void TxtAddModifyProductMin_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAddModifyProductMin.Text, out _))
            {
                txtAddModifyProductMin.BackColor = Color.LightSalmon;
                AllowSave("min", false);
            }
            else
            {
                txtAddModifyProductMin.BackColor = Color.White;
                AllowSave("min", true);
            }
        }
        
        private void BtnAddModifyProductAdd_Click(object sender, EventArgs e)
        {
            if (dgvAllParts.SelectedRows.Count > 0)
            {
                bool match = false;
                foreach (DataGridViewRow dgvRow in dgvAssociatedParts.Rows)
                {
                    if ((Part)dgvRow.DataBoundItem == ((Part)dgvAllParts.CurrentRow.DataBoundItem))
                    {
                        MessageBox.Show("Part is already associated with this product");
                        match = true;
                        break;
                    }
                }
                if (!match)
                {
                    selectedProduct.AddAssociatedPart((Part)dgvAllParts.CurrentRow.DataBoundItem);
                    Inventory.SortAssociatedPartList(selectedProduct);
                }
            }
            else
                MessageBox.Show("Nothing is selected");
        }
        
        private void BtnAddModifyProductDelete_Click(object sender, EventArgs e)
        {
            if (dgvAssociatedParts.SelectedRows.Count > 0)
            {
                _ = selectedProduct.RemoveAssociatedPart(((Part)dgvAssociatedParts.CurrentRow.DataBoundItem).PartID);
            }
            else
                MessageBox.Show("Nothing is selected");
        }
        
        private void BtnAddModifyProductSave_Click(object sender, EventArgs e)
        {
            int max = int.Parse(txtAddModifyProductMax.Text);
            int min = int.Parse(txtAddModifyProductMin.Text);
            int inventory = int.Parse(txtAddModifyProductInventory.Text);
            if (inventory < min || inventory > max)
                MessageBox.Show("Inventory must be within min/max range");
            else if (min > max)
                MessageBox.Show("Min must be less than Max");
            else
            {
                bool overwrite = true;
                if (selectedProduct.AssociatedParts.Count < 1)
                    MessageBox.Show("At least 1 part should be associated with the product");
                if (!isNew)
                {
                    if (MessageBox.Show("Overwrite product?", "Confirm", MessageBoxButtons.YesNo)
                        == DialogResult.No)
                        overwrite = false;
                }
                if (overwrite)
                {
                    AddProduct(selectedProduct);
                    this.Close();
                }
            }
        }
        
        private void AddProduct(Product selectedProduct)
        {
            selectedProduct.ProductID = int.Parse(txtAddModifyProductID.Text);
            selectedProduct.Name = txtAddModifyProductName.Text;
            selectedProduct.InStock = int.Parse(txtAddModifyProductInventory.Text);
            selectedProduct.Price = decimal.Parse(txtAddModifyProductPriceCost.Text);
            selectedProduct.Max = int.Parse(txtAddModifyProductMax.Text);
            selectedProduct.Min = int.Parse(txtAddModifyProductMin.Text);
            if (isNew)
                Inventory.AddProduct(selectedProduct);
            else
                Inventory.UpdateProduct(selectedProduct.ProductID, selectedProduct);
        }
        
        private void BtnAddModifyProductCancel_Click(object sender, EventArgs e)
        {
            selectedProduct.AssociatedParts.Clear();
            
            if (!isNew)
                foreach (Part part in originalAssociation)
                    selectedProduct.AddAssociatedPart(part);
            
            originalAssociation.Clear();
            Dispose(true);
            this.Close();
        }
    }
}
