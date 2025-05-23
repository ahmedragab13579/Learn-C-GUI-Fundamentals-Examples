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
    public partial class FormLogin : Form
    {
        private string UserName = "Ahmed Ragab";
        private string UserPassword = "12345";
        public FormLogin()
        {
            InitializeComponent();
        }


        private void libraryManegmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.ShowDialog();
        }
    }
}
