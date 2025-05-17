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
    public partial class Dialogs : Form
    {
        public Dialogs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (colorDialog1.ShowDialog()==DialogResult.OK) 
                textBox1.BackColor = colorDialog1.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = colorDialog1.Color;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                textBox2.Font = fontDialog1.Font;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog1.Title = "AHMED";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.InitialDirectory = @"C:\";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.Title = "AHMED";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.InitialDirectory = @"C:\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                MessageBox.Show(file);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton= true;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
              
                    MessageBox.Show(folderBrowserDialog1.SelectedPath);
                
            }
            
        }
    }
}
