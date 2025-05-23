using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString().ToLower())
            {
                case "boy":
                    pictureBox1.Image = Resources.Boy;
                    break;
                case "girl":
                    pictureBox1.Image = Resources.Girl;
                    break;
                case "book":
                    pictureBox1.Image = Resources.Book;
                    break;
                case "pen":
                    pictureBox1.Image = Resources.Pen;
                    break;
            }

        }
    }
}
