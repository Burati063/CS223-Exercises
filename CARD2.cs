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
    public partial class CARD2 : UserControl
    {
        private String myVar;

        public String ItemName
        {
            get { return myVar; }
            set { myVar = value;
                label1.Text = value;

            }
        }
        private double myVar2;



        public double Price
        {
            get { return myVar2; }
            set { myVar2 = value;
                label2.Text = value.ToString();
            }
        }

        public CARD2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CARD2_Load(object sender, EventArgs e)
        {

        }

        private void CARD2_Click(object sender, EventArgs e)
        {
            Form2 bn = new Form2();
            bn.Show();

            Item i = new Item();
            i = Item.Search(label1.Text);
            if (i != null)
            {
                // MessageBox.Show($"Found {tb_srch.Text}." +
                //   $" Automatically filled the form according to the Search!");
                bn.txt_itemName.Text = i.ItemName;
                bn.txt_Number.Text = i.Number.ToString();
                bn.txt_price.Text = i.Price.ToString();
                bn.txt_qty.Text = i.Quantity.ToString();
                bn.txt_Sku.Text = i.Sku.ToString();
                bn.dtp.Text = i.Date;

            }
            else
                MessageBox.Show("Sorry Item not found!");
        }
    } 
    }

