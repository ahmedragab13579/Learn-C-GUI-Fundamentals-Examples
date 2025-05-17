using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Station
{
    public partial class ATM : Form
    {
        public ATM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sucssesfully","We Are Happy For Serving You",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }
    }
}
