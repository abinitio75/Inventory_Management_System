using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            dgvParts.DataSource = Inventory.AllParts;
            dgvProducts.DataSource = Inventory.Products;
            dgvParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvParts.Columns["price"].DefaultCellStyle.Format = "C2";
            dgvProducts.Columns["price"].DefaultCellStyle.Format = "C2";
        }
       
        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        
        private void BtnAddPart_Click(object sender, EventArgs e)
        {
                this.Hide();
                new AddModifyPart().ShowDialog();
                this.Show();
        }
        
        private void BtnModifyPart_Click(object sender, EventArgs e)
        {
            if (dgvParts.SelectedRows.Count > 0)
            {
                this.Hide();
                if (dgvParts.CurrentRow.DataBoundItem.GetType() == typeof(Inhouse))
                    new AddModifyPart(((Inhouse)dgvParts.CurrentRow.DataBoundItem)).ShowDialog();
                else
                    new AddModifyPart(((Outsourced)dgvParts.CurrentRow.DataBoundItem)).ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Nothing is selected");
        }
        
        private void BtnDeletePart_Click(object sender, EventArgs e)
        {
            if (dgvParts.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Delete Part?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Inventory.DeletePart((Part)dgvParts.CurrentRow.DataBoundItem);
            }
            else
                MessageBox.Show("Nothing is selected");
        }
        
        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddModifyProduct().ShowDialog();
            this.Show();
        }
        
        private void BtnModifyProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                this.Hide();
                new AddModifyProduct((Product)dgvProducts.CurrentRow.DataBoundItem).ShowDialog();
                this.Show();
            }
            else                
                MessageBox.Show("Nothing is selected");
            
        }
        
        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                if (((Product)dgvProducts.CurrentRow.DataBoundItem).AssociatedParts.Count > 0)
                    MessageBox.Show("Cannot delete product with associated parts");
                else
                {
                    if (MessageBox.Show("Delete Part?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        Inventory.RemoveProduct(((Product)dgvProducts.CurrentRow.DataBoundItem).ProductID);
                }
            }
            else
                MessageBox.Show("Nothing is selected");
        }
        
        private void BtnSearchParts_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtSearchParts.Text))
            {
                Part found;
                if (int.TryParse(txtSearchParts.Text, out int searchID))
                    found = Inventory.LookupPart(searchID);
                else
                    found = Inventory.LookupPart(txtSearchParts.Text);
                if (found.Name != null)
                {
                    foreach (DataGridViewRow searchView in dgvParts.Rows)
                    {
                        if(((Part)searchView.DataBoundItem).PartID == found.PartID)
                        {
                            dgvParts.CurrentRow.Selected = false;
                            searchView.Selected = true;
                            break; 
                        }
                    }
                }
            }
        }
        
        private void BtnSearchProducts_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtSearchProducts.Text))
            {
                Product found;
                if (int.TryParse(txtSearchProducts.Text, out int searchID))
                    found = Inventory.LookupProduct(searchID);
                else
                    found = Inventory.LookupProduct(txtSearchProducts.Text);
                if(found.Name != null)
                {
                    foreach (DataGridViewRow searchView in dgvProducts.Rows)
                    {
                        if (((Product)searchView.DataBoundItem).ProductID == found.ProductID)
                        {
                            dgvProducts.CurrentRow.Selected = false;
                            searchView.Selected = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
