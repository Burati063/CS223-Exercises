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
                String Query = "Insert into dbconnectivety values( 5,'june 6 1994',15,'yabsera',6,500)";
                string connectionstring = "Data source = LAPTOP-TCEBUQVU ; initial catalog = dbconnectivety; Integrated security = true";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                int c = (int)cmd.ExecuteNonQuery();
                MessageBox.Show(c.ToString() + " Number of rows inserted");
             //   MessageBox.Show("db connected");
                con.Close();
            }
            catch (SqlException s) {MessageBox.Show(s.Message);
            }
            }

        }
    }

