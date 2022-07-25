using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class Books
    {
        public void B()
        {
            
            Console.WriteLine("[1] for Adding ");
            Console.WriteLine("[2] for Removing ");
            Console.WriteLine("[3] for Viewing all the available books");

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
                   
                    t.ADD(new Book() { ID = a, Name = b });
                }
                    

                foreach(Book x in t)
                {
                    Console.WriteLine($"Book ID-{x.ID}  Book Name-{x.Name}");
                }
                Console.ReadLine();

            }
        }

    }
}
