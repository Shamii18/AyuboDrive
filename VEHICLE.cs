using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AYUBO_DRIVE
{
    public partial class VEHICLE : Form
    {
        public VEHICLE()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-39A583Q;Initial Catalog=AYUBO_DRIVE;Integrated Security=True");

            string sqlquery = "INSERT INTO VEHICLE (Name,Type,Brand)" +
                    "VALUES('" + textBox1.Text.Trim() + "' , '" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "' )";
            SqlCommand sqlcmd = new SqlCommand(sqlquery, con);
            con.Open();
            sqlcmd.ExecuteNonQuery();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            MessageBox.Show("Sucessfully Updated", "AYUBO_DRIVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlquery = "Delete from VEHICLE";
                SqlCommand sqlcmd = new SqlCommand(sqlquery, con);
                object con = null;
                con.Open();
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully"); //Delete command
                button3.Enabled = true;
                ClearForm();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
