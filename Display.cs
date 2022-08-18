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
            List<Item> pop = new List<Item>();
            pop = Item.getAllProducts();
            foreach (Item i in pop) {
                CARD2 c = new CARD2();
                c.ItemName = i.ItemName;
                c.Price = i.Price;
                flowLayoutPanel1.Controls.Add(c);
            }
        }
    }
}
