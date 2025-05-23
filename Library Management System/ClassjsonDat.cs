using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Library_Management_System
{
    public class ClassjsonDat
    {
        static public string username = "ahmed";
        static public int password = 9999;
        public class Book
        {
            static public List<Book> books = new List<Book>();
            static public List<Book> booksborows = new List<Book>();
            static public List<Book> booksloand = new List<Book>();
            static string filepath = "C:\\Users\\ahmed\\Downloads\\real_books.json";
           
            
            public string Title { get; set; }
            public string Author { get; set; }
            public string Category { get; set; }
            public int Quantity { get; set; }
            public int AvailableCopies { get; set; }

            static public List<Book> loadBookData()
            {
                if (File.Exists(filepath))
                {
                    string file = File.ReadAllText(filepath);
                    books = JsonConvert.DeserializeObject<List<Book>>(file);
                }
                else
                {
                    throw new FileNotFoundException("File not found: " + filepath);
                    MessageBox.Show("The file not found");
                }
                return books;
            }
        }



    }
}
