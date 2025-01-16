using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Travis_Brown_Inventory_Management.Classes {
    public static class Inventory {
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

        public static void addProduct(Product product) => Products.Add(product);


        /*
            May need to check for null here (methods)
            Just writing the core logic
            Will refactor for edge cases
        */

        public static bool removeProduct(int id) {

            foreach (Product prod in Products) {
                if (prod.ProductID == id) {
                    return Products.Remove(prod);
                }
            }
            return false;
        }

        public static Product lookUpProduct(int id) {
            foreach(Product prod in Products) {
                if(prod.ProductID == id) {
                    return prod;
                }
            }
                return null;
        }

        public static void updateProduct(int id, Product updateProd) {
            for(int i = 0; i < Products.Count; i++) {
                if (Products[i].ProductID == id) {
                    Products[i] = updateProd;
                }
            }
        }

        public static void addPart(Part part) => AllParts.Add(part);

        //Not sure if I'll need the ID for the deletePart method
        //Just writing a simple delete method for now.
        public static bool deletePart(Part part) {
            return AllParts.Remove(part);
        }

        public static Part lookupPart(int id) {
            foreach(Part part in AllParts) {
                if(part.PartID == id) {
                    return part;
                }
            }
            return null;
        }

        public static void UpdatePart(int id, Part updatePart) {
            for(int i = 0; i < AllParts.Count; i++) {
                if (AllParts[i].PartID == id) {
                    AllParts[i] = updatePart;
                }
            }
        }



    }
}
