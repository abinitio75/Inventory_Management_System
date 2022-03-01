using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public static class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void GenerateParts()
        {
            AllParts.Add(new Inhouse((AllParts.Count+1), "Handle", 2.20m, 21, 5, 25, 101));
            AllParts.Add(new Inhouse((AllParts.Count + 1), "Spring", 1.80m, 25, 5, 25, 102));
            AllParts.Add(new Inhouse((AllParts.Count + 1), "Pedal", 12.40m, 22, 5, 25, 102));
            AllParts.Add(new Outsourced((AllParts.Count + 1), "Punch", 11.70m, 6, 5, 25, "Rightway Metal Works"));
            AllParts.Add(new Outsourced((AllParts.Count + 1), "Motor", 28.10m, 5, 5, 25, "Keening Fabrication Inc."));
            AllParts.Add(new Outsourced((AllParts.Count + 1), "Blade", 17.25m, 5, 5, 25, "Keening Fabrication Inc."));
        }
        
        public static void GenerateProducts()
        {
            Products.Add(new Product((Products.Count + 1), "Hand Punch", 126.49m, 17, 5, 25));
            Products.Add(new Product((Products.Count + 1), "Press", 254.52m, 12, 5, 25));
            Products.Add(new Product((Products.Count + 1), "Shear", 223.47m, 7, 5, 25));
        }
        
        public static void GenerateAssociation()
        {
            Products[0].AddAssociatedPart(AllParts[0]);
            Products[0].AddAssociatedPart(AllParts[3]);
            Products[1].AddAssociatedPart(AllParts[1]);
            Products[1].AddAssociatedPart(AllParts[4]);
            Products[2].AddAssociatedPart(AllParts[2]);
            Products[2].AddAssociatedPart(AllParts[5]);
        }
        
        public static void SortPartList()
        {
            int id = 1;
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID != id)
                {
                    for (int j = id; j < AllParts.Count; j++)
                    {
                        if (AllParts[j].PartID == id)
                        {
                            AllParts.Insert(i, AllParts[j]);
                            AllParts.RemoveAt(j + 1);
                        }
                    }
                }
                ++id;
            }
        }
        
        public static void SortProductList()
        {
            int id = 1;
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID != id)
                {
                    for (int j = id; j < Products.Count; j++)
                    {
                        if (Products[j].ProductID == id)
                        {
                            Products.Insert(i, Products[j]);
                            Products.RemoveAt(j + 1);
                        }
                    }
                }
                ++id;
            }
        }
        
        public static void SortAssociatedPartList(Product product)
        {
            int id = 1;
            for (int i = 0; i < product.AssociatedParts.Count; i++)
            {
                if (product.AssociatedParts[i].PartID != id)
                {
                    for (int j = id; j < product.AssociatedParts.Count; j++)
                    {
                        if (product.AssociatedParts[j].PartID == id)
                        {
                            product.AssociatedParts.Insert(i, product.AssociatedParts[j]);
                            product.AssociatedParts.RemoveAt(j + 1);
                        }
                    }
                }
                ++id;
            }
        }
        
        public static int SetID(string type)
        {
            int i = 0;
            if (type == "part")
            {
                foreach (Part part in AllParts)
                {
                    ++i;
                    if (part.PartID != i)
                        return i;
                }
                return (AllParts.Count + 1);
            }
            else
            {
                foreach (Product product in Products)
                {
                    ++i;
                    if (product.ProductID != i)
                        return i;
                }
                return (Products.Count + 1);
            }
        }
        
        public static void AddProduct(Product product)
        {
            Products.Add(product);
            SortProductList();
        }
        
        public static bool RemoveProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                    return Products.Remove(product);
            }
            return false;
        }
        
        public static Product LookupProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                    return product;
            }
            return new Product();
        }
        
        public static Product LookupProduct(string name)
        {
            foreach (Product product in Products)
            {
                if (product.Name.ToLower().Contains(name.ToLower()))
                    return product;
            }
            return new Product();
        }
        
        public static void UpdateProduct(int productID, Product updateProduct)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    product.Name = updateProduct.Name;
                    product.Price = updateProduct.Price;
                    product.InStock = updateProduct.InStock;
                    product.Min = updateProduct.Min;
                    product.Max = updateProduct.Max;
                    product.AssociatedParts = updateProduct.AssociatedParts;
                }
            }
        }
        
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
            SortPartList();
        }
        
        public static bool DeletePart(Part part) => AllParts.Remove(part); 


        
        public static Part LookupPart(int partID)
        {
            foreach(Part part in AllParts)
            {
                if (part.PartID == partID)
                    return part;
            }
            return new Inhouse();
        }
        
        public static Part LookupPart(string name)
        {
            foreach (Part part in AllParts)
            {
                if (part.Name.ToLower().Contains(name.ToLower()))
                    return part;
            }
            return new Inhouse();
        }
        
        public static void UpdatePart(int partID, Part updatePart)
        {
            foreach(Part part in AllParts)
            {
                if(part.PartID == partID)
                {
                    part.Name = updatePart.Name;
                    part.InStock = updatePart.InStock;
                    part.Price = updatePart.Price;
                    part.Min = updatePart.Min;
                    part.Max = updatePart.Max;
                    if (updatePart.GetType() == typeof(Inhouse))
                        ((Inhouse)part).MachineID = ((Inhouse)updatePart).MachineID;
                    else
                        ((Outsourced)part).CompanyName = ((Outsourced)updatePart).CompanyName;
                }
            }
        }
    }
}

