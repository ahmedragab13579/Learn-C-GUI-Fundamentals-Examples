using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("hamed");
            checkedListBox1.Items.Add("Ahmed ali hamed hamed ali");
            MessageBox.Show( dateTimePicker1.Value.ToLongDateString());
            MessageBox.Show( dateTimePicker1.Value.ToShortDateString());
            MessageBox.Show( dateTimePicker1.Value.ToShortTimeString());
            MessageBox.Show( dateTimePicker1.Value.ToLongTimeString());
            MessageBox.Show( dateTimePicker1.Value.ToLongDateString());
            MessageBox.Show( dateTimePicker1.Value.ToLongDateString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 3;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited= true;
            System.Diagnostics.Process.Start("https://programmingadvices.com/courses/2012538/lectures/45846237");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text=dateTimePicker1.Text+Environment.NewLine;
            label1.Text+= dateTimePicker1.Value.ToString("dd-MMM-yyyy") + Environment.NewLine;
            label1.Text+= dateTimePicker1.Value.ToString("dddd-MMM-yyyy") + Environment.NewLine;
            label1.Text+= dateTimePicker1.Value.ToString("MM-dd-yyyy") + Environment.NewLine;
            label1.Text+= dateTimePicker1.Value.ToString("dd-MM-yy") + Environment.NewLine;
            label1.Text+= dateTimePicker1.Value.ToString("dddd,dd-MMM-yyyy") + Environment.NewLine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.Start.ToLongDateString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.End.ToLongDateString());

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "صلى على النبى";
        }
    }
}
