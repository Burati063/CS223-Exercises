using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS223_LabSession_4
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            List<Product> pop = new List<Product>();
            pop = Product.getAllProducts();
            foreach (Product i in pop) {
                CARD2 c = new CARD2();
                c.ItemName = i.ItemName;
                c.Price = i.Price;
                c.Click += ( sender2,e2) =>
                {
                   // MessageBox.Show(i.ItemName);
                    ItemFill i2 = new ItemFill(i.ItemName,i.Price,i.Quantity);
                    Details dp = new Details();
                    dp.Controls.Add(i2);
                    dp.Show();

                    
                };
                flowLayoutPanel1.Controls.Add(c);

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
