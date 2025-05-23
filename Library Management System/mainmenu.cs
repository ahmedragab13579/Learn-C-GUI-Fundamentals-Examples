using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
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
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void showTotalnumberofbooks()
       {  
            int count =0;
            foreach(ClassjsonDat.Book b in ClassjsonDat.Book.books)
                    {
               if(b.AvailableCopies>0)
                {
                    count++;
                }

                    }


           l5.Text= count.ToString();

       }
        private void showNumberofborrowers()
        {
            l7.Text = ClassjsonDat.Book.booksborows.Count.ToString();
        }
        private void showNumberofcopiesavailable()
        {
            int number = 0;
            foreach (ClassjsonDat.Book book in ClassjsonDat.Book.books)
            {
                number += book.AvailableCopies;

            }
            l6.Text = number.ToString();    

        }
        private void showNumberofbooksloaned() 
       {

            l8.Text = ClassjsonDat.Book.booksloand.Count.ToString();




        }

        private void mainmenu_Load(object sender, EventArgs e)
        {
            ClassjsonDat.Book.loadBookData();
            showTotalnumberofbooks();
            showNumberofborrowers();
            showNumberofcopiesavailable();
            showNumberofbooksloaned();

        }

        Form libmanagment = new Form1();
        private void libraryManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            libmanagment.ShowDialog();
        }
        Form allavilabelbooks = new AllAvilabelBooks();

        private void allAvilabelBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
                allavilabelbooks.ShowDialog();

        }
        Form login = new login();
        private void libraryManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.Owner = this;
            login.ShowDialog();
        }
    
         public void Updatainfo()
        {

            showTotalnumberofbooks();
            showNumberofborrowers();
            showNumberofcopiesavailable();
            showNumberofbooksloaned();
        }
    
    }
    }

