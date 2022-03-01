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
    public partial class AddModifyPart : Form
    {
        Part selectedPart;
        bool isNew;
        bool isExistingInhouse;
        
        private Dictionary<string, bool> allowSave = new Dictionary<string, bool>()
        {
            {"name", false}, {"inventory", false }, {"price", false }, {"min", false },
            {"max", false }, {"companyOrMachine", false}
        };
        
        public AddModifyPart()
        {
            InitializeComponent();
            isNew = true;
            txtAddModifyPartID.Text = Inventory.SetID("part").ToString();
            lblAddModifyPart.Text = "Add Part";
            lblAddModifyPartMachineOrCompanyID.Text = "Machine ID";
            rdoBtnAddPartInhouse.Checked = true;
            btnAddModifySavePart.Enabled = false;
            txtAddModifyPartID.Enabled = false;
            txtAddModifyPartID.BackColor = Color.LightGray;
            txtAddModifyPartID.BackColor = Color.LightGray;
            txtAddModifyPartName.BackColor = Color.LightSalmon;
            txtAddModifyPartInventory.BackColor = Color.LightSalmon;
            txtAddModifyPartPriceCost.BackColor = Color.LightSalmon;
            txtAddModifyPartMin.BackColor = Color.LightSalmon;
            txtAddModifyPartMax.BackColor = Color.LightSalmon;
            txtAddModifyPartCompanyOrMachineID.BackColor = Color.LightSalmon;
            selectedPart = new Inhouse();
        }
        
        public AddModifyPart(Inhouse inhouse)
        {
            InitializeComponent();
            isNew = false;
            lblAddModifyPart.Text = "Modify Part";
            lblAddModifyPartMachineOrCompanyID.Text = "Machine ID";
            txtAddModifyPartID.Enabled = false;
            txtAddModifyPartID.BackColor = Color.LightGray;
            rdoBtnAddPartInhouse.Checked = true;
            txtAddModifyPartID.Text = inhouse.PartID.ToString();
            txtAddModifyPartName.Text = inhouse.Name;
            txtAddModifyPartInventory.Text = inhouse.InStock.ToString();
            txtAddModifyPartPriceCost.Text = inhouse.Price.ToString();
            txtAddModifyPartMax.Text = inhouse.Max.ToString();
            txtAddModifyPartMin.Text = inhouse.Min.ToString();
            txtAddModifyPartCompanyOrMachineID.Text = inhouse.MachineID.ToString();
            selectedPart = inhouse;
        }
        
        public AddModifyPart(Outsourced outsourced)
        {
            InitializeComponent();
            isNew = false;
            lblAddModifyPart.Text = "Modify Part";
            lblAddModifyPartMachineOrCompanyID.Text = "Company    ";
            rdoBtnAddPartOutsourced.Checked = true;
            txtAddModifyPartID.Enabled = false;
            txtAddModifyPartID.BackColor = Color.LightGray;
            txtAddModifyPartID.Text = outsourced.PartID.ToString();
            txtAddModifyPartName.Text = outsourced.Name;
            txtAddModifyPartInventory.Text = outsourced.InStock.ToString();
            txtAddModifyPartPriceCost.Text = outsourced.Price.ToString();
            txtAddModifyPartMax.Text = outsourced.Max.ToString();
            txtAddModifyPartMin.Text = outsourced.Min.ToString();
            txtAddModifyPartCompanyOrMachineID.Text = outsourced.CompanyName;
            selectedPart = outsourced;
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
                case "companyOrMachine":
                    allowSave[field] = value;
                    break;
                default:
                    break;
            }
            btnAddModifySavePart.Enabled = !allowSave.ContainsValue(false);
        }
        
        private void RdoBtnAddPartInhouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtnAddPartInhouse.Checked)
            {
                lblAddModifyPartMachineOrCompanyID.Text = "Machine ID";
                if (!int.TryParse(txtAddModifyPartCompanyOrMachineID.Text, out _))
                {
                    txtAddModifyPartCompanyOrMachineID.BackColor = Color.LightSalmon;
                    AllowSave("companyOrMachine", false);
                }
                else
                {
                    txtAddModifyPartCompanyOrMachineID.BackColor = Color.White;
                    AllowSave("companyOrMachine", true);
                }
            }
            else
            {
                lblAddModifyPartMachineOrCompanyID.Text = "Company    ";
                if (!Regex.IsMatch(txtAddModifyPartCompanyOrMachineID.Text, "^[a-zA-Z]"))
                {
                    txtAddModifyPartCompanyOrMachineID.BackColor = Color.LightSalmon;
                    AllowSave("companyOrMachine", false);
                }
                else
                {
                    txtAddModifyPartCompanyOrMachineID.BackColor = Color.White;
                    AllowSave("companyOrMachine", true);
                }
            }
        }
        
        private void TxtAddModifyPartID_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void TxtAddModifyPartName_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtAddModifyPartName.Text, "^[a-zA-Z]"))
            {
                txtAddModifyPartName.BackColor = Color.LightSalmon;
                AllowSave("name", false);
            }
            else
            {
                txtAddModifyPartName.BackColor = Color.White;
                AllowSave("name", true);
            }
        }
        
        private void TxtAddModifyPartInventory_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAddModifyPartInventory.Text, out _))
            {
                txtAddModifyPartInventory.BackColor = Color.LightSalmon;
                AllowSave("inventory", false);
            }
            else
            {
                txtAddModifyPartInventory.BackColor = Color.White;
                AllowSave("inventory", true);
            }
        }
        
        private void TxtAddModifyPartPriceCost_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAddModifyPartPriceCost.Text, out _))
            {
                txtAddModifyPartPriceCost.BackColor = Color.LightSalmon;
                AllowSave("price", false);
            }
            else
            {
                txtAddModifyPartPriceCost.BackColor = Color.White;
                AllowSave("price", true);
            }
        }
        
        private void TxtAddModifyPartMax_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAddModifyPartMax.Text, out _))
            {
                txtAddModifyPartMax.BackColor = Color.LightSalmon;
                AllowSave("max", false);
            }
            else
            {
                txtAddModifyPartMax.BackColor = Color.White;
                AllowSave("max", true);
            }
        }
        
        private void TxtAddModifyPartMin_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAddModifyPartMin.Text, out _))
            {
                txtAddModifyPartMin.BackColor = Color.LightSalmon;
                AllowSave("min", false);
            }
            else
            {
                txtAddModifyPartMin.BackColor = Color.White;
                AllowSave("min", true);
            }
        }
        
        private void TxtAddModifyPartCompanyOrMachineID_TextChanged(object sender, EventArgs e)
        {
            if (rdoBtnAddPartInhouse.Checked)
            {
                if (!int.TryParse(txtAddModifyPartCompanyOrMachineID.Text, out _))
                {
                    txtAddModifyPartCompanyOrMachineID.BackColor = Color.LightSalmon;
                    AllowSave("companyOrMachine", false);
                }
                else
                {
                    txtAddModifyPartCompanyOrMachineID.BackColor = Color.White;
                    AllowSave("companyOrMachine", true);
                }
            }
            else
            {
                if (!Regex.IsMatch(txtAddModifyPartCompanyOrMachineID.Text, "^[a-zA-Z]"))
                {
                    txtAddModifyPartCompanyOrMachineID.BackColor = Color.LightSalmon;
                    AllowSave("companyOrMachine", false);
                }
                else
                {
                    txtAddModifyPartCompanyOrMachineID.BackColor = Color.White;
                    AllowSave("companyOrMachine", true);
                }
            }
        }
        
        private void BtnAddModifySavePart_Click(object sender, EventArgs e)
        {
            int max = int.Parse(txtAddModifyPartMax.Text);
            int min = int.Parse(txtAddModifyPartMin.Text);
            int inventory = int.Parse(txtAddModifyPartInventory.Text);
            if (inventory < min || inventory > max)
                MessageBox.Show("Inventory must be within min/max range");
            else if (min > max)
                MessageBox.Show("Min must be less than Max");
            else
            {
                int id = int.Parse(txtAddModifyPartID.Text);
                bool inventoryDuplicate = false;
                bool overwrite = true;
                foreach (Part part in Inventory.AllParts)
                {
                    if (part.PartID == id)
                    {
                        inventoryDuplicate = true;
                        
                        if (part.GetType() == typeof(Inhouse))
                            isExistingInhouse = true;
                        else
                            isExistingInhouse = false;
                    }
                }
                if (inventoryDuplicate)
                    if (MessageBox.Show("Part already exists\nOverwrite?", "Confirm",
                        MessageBoxButtons.YesNo) == DialogResult.No)
                        overwrite = false;
                
                if(overwrite)
                {
                    AddPart();
                    this.Close();
                }
            }
        }
        
        private void AddPart()
        {
            if (rdoBtnAddPartInhouse.Checked)
            {
                if (!isExistingInhouse)
                {
                    Inventory.DeletePart(selectedPart);
                    isNew = true;
                }
                selectedPart = new Inhouse()
                {
                    PartID = int.Parse(txtAddModifyPartID.Text),
                    Name = txtAddModifyPartName.Text,
                    Price = decimal.Parse(txtAddModifyPartPriceCost.Text),
                    InStock = int.Parse(txtAddModifyPartInventory.Text),
                    Min = int.Parse(txtAddModifyPartMin.Text),
                    Max = int.Parse(txtAddModifyPartMax.Text),
                    MachineID = int.Parse(txtAddModifyPartCompanyOrMachineID.Text)
                };
            }
            else
            {
                if (isExistingInhouse)
                {
                    Inventory.DeletePart(selectedPart);
                    isNew = true;
                }
                selectedPart = new Outsourced()
                {
                    PartID = int.Parse(txtAddModifyPartID.Text),
                    Name = txtAddModifyPartName.Text,
                    Price = decimal.Parse(txtAddModifyPartPriceCost.Text),
                    InStock = int.Parse(txtAddModifyPartInventory.Text),
                    Min = int.Parse(txtAddModifyPartMin.Text),
                    Max = int.Parse(txtAddModifyPartMax.Text),
                    CompanyName = txtAddModifyPartCompanyOrMachineID.Text
                };
            }
            if (isNew)
                Inventory.AddPart(selectedPart);
            else
                Inventory.UpdatePart(selectedPart.PartID, selectedPart);

            Dispose(true);
        }
        
        private void BtnAddModifyCancelAddPart_Click(object sender, EventArgs e)
        {
            Dispose(true);
            this.Close();
        }
    }
}

