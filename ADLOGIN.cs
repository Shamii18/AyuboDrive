using AYUBO_DRIVE;
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

namespace WinFormsApp3
{
    public partial class ADLOGIN : Form
    {
        public ADLOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-39A583Q;Initial Catalog=AYUBO_DRIVE;Integrated Security=True");

            string sqlquery = "INSERT INTO ADLOGIN (USERNAME,PASSWORD)" +
                    "VALUES('" + textBox1.Text.Trim() + "' , '" + textBox2.Text.Trim() + "')";
            SqlCommand sqlcmd = new SqlCommand(sqlquery, con);
            con.Open();
            sqlcmd.ExecuteNonQuery();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            MessageBox.Show("Sucessfully Login", "AYOBO DRIVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            MAIN_MENU obj = new MAIN_MENU();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
