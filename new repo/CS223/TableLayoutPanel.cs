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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
           // flowLayoutPanel1.Controls.Add() ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved:>>"+"\n"+textBox1.Text+" ");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
