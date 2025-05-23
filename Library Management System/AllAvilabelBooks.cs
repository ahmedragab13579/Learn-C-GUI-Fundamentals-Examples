using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library_Management_System
{
    public partial class AllAvilabelBooks : Form
    {
        public AllAvilabelBooks()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            foreach (ClassjsonDat.Book book in ClassjsonDat.Book.books)
            {
                if (book.AvailableCopies != 0)
                {
                    TreeNode root = new TreeNode(book.Title);
                    root.Nodes.Add("Author: " + book.Author);
                    root.Nodes.Add("Category: " + book.Category);
                    root.Nodes.Add("Quantity: " + book.Quantity);
                    root.Nodes.Add("Available Copies: " + book.AvailableCopies);

                    root.ImageIndex = 0;
                    root.SelectedImageIndex = 0;
                    treeView1.Nodes.Add(root);
                }
            }
        }


    
    }
}
