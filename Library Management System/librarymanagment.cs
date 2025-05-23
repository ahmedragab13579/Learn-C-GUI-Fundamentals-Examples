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
    public partial class librarymanagment : Form
    {
        public mainmenu MainFormRef { get; set; }

        public librarymanagment()
        {
            InitializeComponent();
        }

        private void librarymanagment_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ClassjsonDat.Book.books;
            dataGridView1.ReadOnly = true;
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                MessageBox.Show($"Title:{dataGridView1.SelectedRows[0].Cells["Title"].Value.ToString()}\n" +
                    $"Author:{dataGridView1.SelectedRows[0].Cells["Author"].Value.ToString()}\n" +
                    $"Category:{dataGridView1.SelectedRows[0].Cells["Category"].Value.ToString()}\n" +
                    $"Quantity:{dataGridView1.SelectedRows[0].Cells["Quantity"].Value.ToString()}\n" +
                    $"AvailableCopies:{dataGridView1.SelectedRows[0].Cells["AvailableCopies"].Value.ToString()}");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                contextMenuStrip3.Show(Cursor.Position);
            }
        }
        private void DeleteItem(ClassjsonDat.Book book)
        {
            ClassjsonDat.Book.books.Remove(book);

        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Now you delete this row are you Confident", "Confident Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ClassjsonDat.Book book = (ClassjsonDat.Book)dataGridView1.SelectedRows[0].DataBoundItem;
                DeleteItem(book);
                if (MainFormRef != null)
                {
                    MainFormRef.Updatainfo();
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ClassjsonDat.Book.books;
            }

        }

        private void Enableall()
        {
            dataGridView1.Width = 579;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            button1.Enabled = true;
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
        }

        private void visibleall()
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            button1 .Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;


        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

            visibleall();
            Enableall();






        }


        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider1.SetError(textBox1, "you can leave it empaty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");



            }

        }
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "you can leave it empaty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox2, "");



            }

        }
        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider1.SetError(textBox3, "you can leave it empaty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox3, "");


            }

        }
        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
               
                    e.Cancel = true;
                    textBox2.Focus();
                    errorProvider1.SetError(textBox4, "you can leave it empaty");
                
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox4, "");



            }

        }
        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                
                    e.Cancel = true;
                    textBox2.Focus();
                    errorProvider1.SetError(textBox5, "you can leave it empaty");
                
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox5, "");



            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)|| string.IsNullOrEmpty(textBox3.Text)|| string.IsNullOrEmpty(textBox4.Text)|| string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("please fill all information");

            }
            else
            {
                
                ClassjsonDat.Book book = new ClassjsonDat.Book();
                book.Title = textBox1.Text;
                book.Author = textBox2.Text;
                book.Category= textBox3.Text;   
                book.Quantity = int.Parse(textBox4.Text);
                book.AvailableCopies = int.Parse(textBox5.Text);  
                ClassjsonDat.Book.books.Add(book);
                MainFormRef.Updatainfo();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ClassjsonDat.Book.books;

            }


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

       

        private void borowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassjsonDat.Book book = (ClassjsonDat.Book)dataGridView1.SelectedRows[0].DataBoundItem;
            if (book.AvailableCopies <= 0)
            {
                MessageBox.Show("this book has no available copies");
            }
            else
            {
                int index=ClassjsonDat.Book.books.FindIndex(b=>b.Title==book.Title);
                if (index!=-1)
                {  ClassjsonDat.Book.books[index].AvailableCopies -= 1;
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ClassjsonDat.Book.books;
                    ClassjsonDat.Book.booksborows.Add(ClassjsonDat.Book.books[index]);
                    ClassjsonDat.Book.booksloand.Add(ClassjsonDat.Book.books[index]);
                    MainFormRef.Updatainfo();
                }


            }




        }
    }
}
                                                                