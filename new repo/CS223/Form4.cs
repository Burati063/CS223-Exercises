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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            Pnl_indicator.BackColor = Color.Black;
            Pnl_indicator.Top = 246;
        }


        private void label1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            Pnl_indicator.BackColor = Color.Black;
            Pnl_indicator.Top = 60;


              
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            Pnl_indicator.Top=149;
        }
    }
}
