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
    public partial class listview : Form
    {
        public listview()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count<10)
           { for (int i = 0; i < 10; i++)
                {
                    ListViewItem listView = new ListViewItem(i.ToString());
                    if (i % 2 == 0)
                    {
                        listView.ImageIndex = 1;
                    }
                    else
                    {
                        listView.ImageIndex = 0;
                    }
                    listView.SubItems.Add("Person" + (i + 1).ToString());
                    listView1.Items.Add(listView);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("The Maximum in one fill is 10");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count>0)
            {
                listView1.Items.Remove(listView1.Items[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text)|| string.IsNullOrEmpty(textBox2.Text))
            {
                return;
            }
            ListViewItem listView = new ListViewItem(textBox2.Text.Trim());
            if (radioButton6.Checked)
            {
                listView.ImageIndex = 1;
            }
            else
            {
                listView.ImageIndex = 0; 
            }
            listView.SubItems.Add(textBox1.Text.Trim());
            listView1.Items.Add(listView);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }
    }
}
