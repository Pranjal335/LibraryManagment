﻿using System;

namespace LibraryManagment
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(" Select your identity: ");
            Console.WriteLine();
            Console.WriteLine(" Press 1 For 'Librarian' ");
            Console.WriteLine(" Press 2 For 'Student' ");
            Console.WriteLine();
            string chosen= Console.ReadLine();
            int x=int.Parse(chosen);

            Librarian l =new Librarian();
            Students s= new Students();

            switch(x)
            {
                case 1:
                    l.a();
                    break;
                case 2:
                    s.studentPortal();
                    break;

            }
        }
    }

   
}
