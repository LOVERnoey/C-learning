using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch {
    class Book {
        public string title;
        public string author;
        public int pages;

        public Book()
        {
            Console.WriteLine("Object create");
        }
        public Book(string aTitle, string aAuthor, int aPages)
        {
            Console.WriteLine("Object create");
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
        public void Display() 
        {
            Console.WriteLine(title);
            Console.WriteLine(author);
            Console.WriteLine(pages);

        }

        public bool NumofPages()
        {
            if (pages < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
