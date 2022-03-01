using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Inventory_Management_System
{
    public abstract class Part
    {
        private int _partID;
        private string _name;
        private decimal _price;
        private int _inStock;
        private int _min;
        private int _max;

        public int PartID { get => _partID; set => _partID = value; }
        public string Name { get => _name; set => _name = value; }
        public decimal Price { get => _price; set => _price = value; }
        public int InStock { get => _inStock; set => _inStock = value; }
        public int Min { get => _min; set => _min = value; }
        public int Max { get => _max; set => _max = value; }
        
        public Part() { }
    }
}
