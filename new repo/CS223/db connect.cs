using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CS223_LabSession_4
{
    public partial class db_connect : Form
    {
        public db_connect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = "Data source = LAPTOP-TCEBUQVU ; initial catalog = dbconnectivety; Integrated security = true";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                MessageBox.Show("db connected");
                con.Close();
            }
            catch (SqlException s) {MessageBox.Show("db not connected");
            }
            }

        }
    }

