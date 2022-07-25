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
            new Book{ID=1,Name="alpha" },
            new Book{ID=2,Name="alpha" },
            new Book{ID=3,Name="alpha" },
            new Book{ID=4,Name="alpha" },
            new Book{ID=5,Name="alpha" }
    

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
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
