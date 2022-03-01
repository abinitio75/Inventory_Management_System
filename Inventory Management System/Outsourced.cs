using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public class Outsourced : Part
    {
        private string _companyName;

        public string CompanyName { get => _companyName; set => _companyName = value; }
        
        public Outsourced() { }
        
        public Outsourced(int count, string name, decimal price,
            int inStock, int min, int max, string companyName)
        {
            PartID = count;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }
    }
}
