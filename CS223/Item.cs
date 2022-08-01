using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS223_LabSession_4
{
    class Item
    {ArrayList m = new ArrayList();
       static List<Item> Products = new List<Item>();
        public int Number { get; set; }
        public String Date { get; set; }
        public int Sku { get; set; }
        public String ItemName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public bool ISAVA { get; set; }
        public String type { get; set; }
     //   public bool simple { get; set; }

        public void save() {
            /*m.Add(8);
             m.Add("N");
             m.Add(true);
             m.Add(new Item());
             Products.Add(this);
             */
            Products.Add(this);
            MessageBox.Show("Data Added Successfully "+this.type);
            

            
        }
        public static List<Item> getAllProducts() {
            return Products;
        }


    }


}
