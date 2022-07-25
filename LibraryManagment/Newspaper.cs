using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class Newspaper
    {
        

        public void news()
        {
            Console.WriteLine("[1] Viewing all the available newspaper");

            int x  = Convert.ToInt32(Console.ReadLine());

            newspaperOperation n = new newspaperOperation();

            if(x == 1)
            {
                foreach (Paper y in n)
                {
                    Console.WriteLine($"Title- {y.Title}");
                }
                Console.ReadLine();
            }

        }
    }
}
