using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace Inventory_Management_System
{
    public class Product
    {
        private int productID;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;

        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        
        public int ProductID { get => productID; set => productID = value; }
        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }
        public int InStock { get => inStock; set => inStock = value; }
        public int Min { get => min; set => min = value; }
        public int Max { get => max; set => max = value; }

        public Product() { }
        
        public Product(int count, string name, decimal price, int inStock,
            int min, int max)
        {
            ProductID = count;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public void AddAssociatedPart(Part part) => AssociatedParts.Add(part);


        public bool RemoveAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                    return AssociatedParts.Remove(part);
            }
                return false;
        }
        
        public Part LookupAssociatedPart(int partID)
        {
            foreach(Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                    return part;
            }
            return new Inhouse();
        }
    }
}
