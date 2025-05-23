using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class ErorrProvider : Form
    {
        public ErorrProvider()
        {
            InitializeComponent();
        }

      
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "you cannot leave it empaty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, string.Empty);
            }
        }

        
    }
}
