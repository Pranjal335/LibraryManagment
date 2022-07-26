using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class Newspaper:Librarian
    {
        

        public void news()
        {
            Console.WriteLine();
            Console.WriteLine("[1] Viewing all the available newspaper");
            Console.WriteLine("[2] Back");
            Console.WriteLine();

            int x  = Convert.ToInt32(Console.ReadLine());

            newspaperOperation n = new newspaperOperation();

            if(x == 1)
            {
                foreach (Paper y in n)
                {
                    Console.WriteLine($"Title- {y.Title}");
                }
                Console.WriteLine();
                news();
            }
            else if (x == 2)
            {
                a();

            }

        }
    }
}
