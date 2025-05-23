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
    public partial class tabcontrol : Form
    {
        public tabcontrol()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();  
                errorProvider1.SetError(textBox1, "You cannot Leacve It Empaty");
            }
            else
            {
                e.Cancel= false;
                errorProvider1.Clear();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("write a task");
            }
            else
            {
            
                
                listBox1.Items.Add(textBox1.Text);
                listBox4.Items.Add(textBox1.Text);
                textBox1.Clear();
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox3.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox4.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("chose an item");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("write a task");
            }
            else
            {


                listBox2.Items.Add(textBox2.Text);
                listBox4.Items.Add(textBox2.Text);
                textBox2.Clear();
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.ShowBalloonTip(1000);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (listBox2.SelectedItem != null)
            {
                listBox3.Items.Add(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
                listBox4.Items.Remove(listBox2.SelectedItem);
            }
            else
            {
                MessageBox.Show("chose an item");
            }
        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            listBox4.Items.Clear();
        }

    }
}
