using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management_System
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "you can leave it empaty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox2, "");


            }
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "you can leave it empaty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");



            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            librarymanagment frm3 = new librarymanagment();
            if(textBox2.Text==ClassjsonDat.username && textBox1.Text == ClassjsonDat.password.ToString())
            {
                frm3.MainFormRef = this.Owner as mainmenu; 
                frm3.Show();
            }
            else
            {
                MessageBox.Show("wrong password or username");

            }
        }
    }
}
