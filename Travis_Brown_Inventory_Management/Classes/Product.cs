using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travis_Brown_Inventory_Management.Classes {
    public class Product {
        public BindingList<Part> AssociatedParts { get; set; } = [];

        public int ProductID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int InStock { get; set; }

        public int Min { get; set; }
        public int Max { get; set; }


        public void addAssociatedPart(Part part) => AssociatedParts.Add(part);

        public bool removeAssociatedPart(Part part) {
            return AssociatedParts.Remove(part);
        }

        public Part lookUpAssociatedPart(int id) {
            foreach(Part part in AssociatedParts) {
                if(part.PartID == id) {
                    return part;
                }
            }
            return null;
        }
    }
}
