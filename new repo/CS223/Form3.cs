﻿using System;
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
               
              /*  Form opened;
                 opened = Form3.ActiveForm;
                if (opened != null)
                    opened.Close();
                    
                */Inventory f = new Inventory(tb_usr.Text);
                f.Show();
                
            }

            else { MessageBox.Show("Incorrect Credential"); }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Item changed!"); 
        }
    }
}
