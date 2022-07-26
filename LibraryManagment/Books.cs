using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class Books:Newspaper
    {
        public void B()
        {
            Console.WriteLine();
            Console.WriteLine("[1] for Adding ");
            Console.WriteLine("[2] for Removing ");
            Console.WriteLine("[3] for Viewing all the available books");
            Console.WriteLine("[4] for Back");
            Console.WriteLine();

            Addition t = new Addition();

            string input = Console.ReadLine();
            int z = int.Parse(input);

            if (z == 1)
            {
                Console.WriteLine("How Many Books You Want to Add Now");
                int quantity=Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < quantity; i++) {
                    Console.WriteLine("Please Enter Book ID: ");
                    int a = Convert.ToInt32(Console.ReadLine());


                   
                    Console.WriteLine("Please Enter Book Name: ");
                    string b = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    t.ADD(new Book{ ID = a, Name = b });
                }
                    

                foreach(Book x in t)
                {
                    Console.WriteLine($"Book ID-{x.ID}  Book Name-{x.Name}");
                }
                Console.WriteLine();

                B();

            }
            else if(z == 2)
            {
                Console.WriteLine("Type Book code to Remove: ");
                int i = Convert.ToInt32(Console.ReadLine());
                t.Rem(i);

                foreach (Book x in t)
                {
                    Console.WriteLine($"Book ID-{x.ID}  Book Name-{x.Name}");
                }
                Console.WriteLine();
                B();
            }
            else if(z==3)
            {
                foreach (Book x in t)
                {
                    Console.WriteLine($"Book ID-{x.ID}  Book Name-{x.Name}");
                }
                Console.WriteLine();
                B();
            }
            else
            {
                Console.WriteLine("[1] for Books, [2] for Newspaper ");
                int y = Convert.ToInt32(Console.ReadLine());
                if (y == 1)
                {
                    B();
                }
                else if (y == 2)
                {
                    news();
                }
            }
        }

    }
}
