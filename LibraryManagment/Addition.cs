using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class Addition:IEnumerable
    {
        public static List<Book> books = new List<Book>
        {
            new Book{ID=1,Name="Book1" },
            new Book{ID=2,Name="Book2" },
            new Book{ID=3,Name="Book3" },
            new Book{ID=4,Name="Book4" },
            new Book{ID=5,Name="Book5" },
            new Book{ID=6,Name="Book6" },
            new Book{ID=7,Name="Book7" },
            new Book{ID=8,Name="Book8" },
            new Book{ID=9,Name="Book9" },
            new Book{ID=10,Name="Book10" }
        };

        public void ADD(Book NewBook)
        {
            if (books == null)
            {
                books = new List<Book>();
              
            }
            books.Add(NewBook);
            
        }

        public void Rem(int i)
        {
            if (books != null)
            {
                books.RemoveAll(r => r.ID == i);
                
            }
            
        }


        public IEnumerator GetEnumerator()
        {
            if (books != null)
            {
                return books.GetEnumerator();
            }
            else
            {
                return null;
            }

        }

    }

   

    public class Book
    {
        public Boolean IsBorrowed
        { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
