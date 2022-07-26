using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class Students
    {
        public void stu()

        {
           
            Console.WriteLine();
            Console.WriteLine("Hello You Have Just Entered In Student Portal");
            Console.WriteLine("Press 1 to BorrowBook");
            Console.WriteLine("Press 2 to ReturnBook");
            Console.WriteLine("Press 3 to View Available Books");
            Console.WriteLine();
            int x=Convert.ToInt32(Console.ReadLine());

            Addition t = new Addition();

            StudentBook obj = new StudentBook();

            if (x == 1)
            {
                obj.BorrowOperation();
            }
            else if (x == 2)
            {
                obj.ReturnOperation();
            }
            else if (x == 3)
            {
                foreach (Book b in t)
                {
                    Console.WriteLine($"Book ID-{b.ID}  Book Name-{b.Name}");
                }

            }

            stu();
        }
       
    }
}
