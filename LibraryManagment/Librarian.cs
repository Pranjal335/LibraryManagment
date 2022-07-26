using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class Librarian:Program
    {
        public void a()
        {
            Console.WriteLine();
            Console.WriteLine("-------------Welcome Sir----------------");
            Console.WriteLine();
            Console.WriteLine("------What do you want to manage today?------");
            Console.WriteLine("[1] for Books, [2] for Newspaper, [3] to end this session ");

            Librarian l = new Librarian();

            string LibrarianChoice= Console.ReadLine();
            int y= int.Parse(LibrarianChoice);

            Books b = new Books();
            Newspaper p = new Newspaper();

            if (y == 1)
            {
                b.B();
            }
            else if(y == 2)
            {
                p.news();

            }
            


        }
    }
}
