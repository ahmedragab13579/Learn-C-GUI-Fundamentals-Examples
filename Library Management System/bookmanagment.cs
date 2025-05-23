using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Library_Management_System.ClassjsonDat;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void makethelist(ClassjsonDat.Book book)
        {
            ListViewItem item = new ListViewItem(book.Title);
            item.SubItems.Add(book.Author);
            item.SubItems.Add(book.Category);
            item.SubItems.Add(book.Quantity.ToString());
            item.SubItems.Add(book.AvailableCopies.ToString());
            listView1.Items.Add(item);
        }
        
        
        private void FindTheBookbyname() 
        {
            string name = textBox2.Text;
            foreach (ClassjsonDat.Book book in ClassjsonDat.Book.books)
            {
                if (book.Title == name)
                {

                    makethelist(book);
                    break;
                }

            }
        }
        private void FindTheBookbyauther() 
        {
            string name = textBox2.Text;
            foreach (ClassjsonDat.Book book in ClassjsonDat.Book.books)
            {
                if (book.Author == name)
                {

                    makethelist(book);
                }

            }
        }
        private void FindTheBookbycategory() 
        {
            string name = textBox2.Text;
            foreach (ClassjsonDat.Book book in ClassjsonDat.Book.books)
            {
                if (book.Category == name)
                {

                    makethelist(book);
                }

            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider1.CanExtend("you cannot leave it empaty");


            }
            else
            {
                e.Cancel = false;


            }
        }

      

        private void searchByNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Text = "search By Name";
            FindTheBookbyname();
        }

        private void searchByAutherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Text = "search By Auther";
            FindTheBookbyauther();

        }

        private void searchByCatigoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Text = "search By Catigory";
            FindTheBookbycategory();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
