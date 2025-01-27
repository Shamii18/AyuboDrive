using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AYUBO_DRIVE
{
    public partial class MAIN_MENU : Form
    {
        public MAIN_MENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VEHICLE vehi = new VEHICLE();
            vehi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VEHICLE_TYPE VT = new VEHICLE_TYPE();
            VT.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RENT_CAR RC = new RENT_CAR();
            RC.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PACKAGES PACK = new PACKAGES();
            PACK.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form LOG = new Form();
            LOG.Show();
        }
    }
}
