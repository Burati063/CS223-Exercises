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
    public partial class ContainerPage : Form
    {
        public ContainerPage()
        {
            InitializeComponent();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form opened = this.ActiveMdiChild;
            if (opened != null)
            {
                opened.Close();
            }
            Form3 Screen = new Form3();
            Screen.MdiParent = this;
            Screen.Show();

        }

        private void displayAllProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form opened = this.ActiveMdiChild;
            if (opened != null)
            {
                opened.Close();
            }
            Form2 f = new Form2();
            f.MdiParent = this;
            f.Show();
        }

        private void searchProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}