using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public class Inhouse : Part
    {
        private int _machineID;
        
        public int MachineID { get => _machineID; set => _machineID = value; }
        
        public Inhouse() { }
        
        public Inhouse(int count, string name, decimal price, 
            int inStock, int min, int max, int machineID)
        {
            PartID = count;
            Name = name;
            Price = price; 
            InStock = inStock;
            Min = min;
            Max = max;
            MachineID = machineID;
        }
    }
}
