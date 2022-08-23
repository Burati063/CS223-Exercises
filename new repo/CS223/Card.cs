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
    public partial class Card : UserControl
    {
        
        private String _name;

        public String ProductNames
        {
            get { return _name; }
            set { _name = value; label1.Text = value;
               // MessageBox.Show("Changed it");
            }
        }

        public Card()
        {
            InitializeComponent();
        }
    }
}
