using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Multi_Note_Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient client)
                {
                    client.BackgroundImage = Image.FromFile("D:\\course 14 abohadhod C#\\case-with-schedule-pencils\\62076-OAE2L6-743.JPG"); // أو استخدم Properties.Resources.YourImage لو الصورة مضافة في الموارد
                    client.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                }
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }
        }

        private Form newNote = new Form2();
        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newNote.MdiParent = this;
            newNote.Show();
        }

        private void saveTXTNoteToolStripMenuItem_Click(object sender, EventArgs e)
        
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(saveFileDialog.FileName, ((Form2)newNote).TextBoxValue);

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}

