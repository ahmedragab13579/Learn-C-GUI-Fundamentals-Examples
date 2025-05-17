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
    public partial class Trackbar : Form
    {
        public Trackbar()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           label2.Text=trackBar1.Value.ToString();
            pictureBox1.Size = new Size(trackBar1.Value, trackBar1.Value);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = numericUpDown1.Value.ToString();
            pictureBox1.Size = new Size((int)numericUpDown1.Value, (int)numericUpDown1.Value);
        }
    }
}
