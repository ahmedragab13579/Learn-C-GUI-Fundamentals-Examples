using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label1.Parent = this;
            button1.BackColor = Color.Transparent;
            button1.Parent = this;
            button2.BackColor = Color.Transparent;
            button2.Parent = this;

        }

      
            Form form = new mainmenu();
        private void button2_Click(object sender, EventArgs e)
        {
            form.ShowDialog();
        }
    }
}
