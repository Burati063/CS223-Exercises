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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_usr.Text) && tb_pwd.Text == "ADMIN")
            {
                this.Hide();
                Form2 f = new Form2(tb_usr.Text);
                f.Show();
            }
            else { MessageBox.Show("Incorrect Credential"); }
        }
    }
}
