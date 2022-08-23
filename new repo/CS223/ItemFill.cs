using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS223_LabSession_4
{
    public partial class ItemFill : UserControl
    {
        public ItemFill()
        {
            InitializeComponent();
        }

        public ItemFill(string name,double price,int qty) {
            InitializeComponent();
            label2.Text = name.ToString();
            label3.Text = price.ToString();
            lblqty.Text = qty.ToString();
        }

        private void ItemFill_Load(object sender, EventArgs e)
        {

        }
    }
}
