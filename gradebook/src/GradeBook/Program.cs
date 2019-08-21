using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> {1, 4};
            System.Console.WriteLine("Size = " + numbers.Count);
            System.Console.WriteLine("numbers = " + numbers[1]);
            Book b = new Book();
            if(args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}");
            }
            else
            {
                Console.WriteLine("Nothing!");
            }

            Book book1 = new Book();
            book1.AddGrade(5.8);
            book1.AddGrade(8.5);
            book1.AddGrade(4.2);
            System.Console.WriteLine("Average = " + book1.Average());
            System.Console.WriteLine("MaxGrade = " + book1.MaxGrade());
            System.Console.WriteLine("MinGrade = " + book1.MinGrade());
            System.Console.WriteLine("Book1 = " + book1.ToString());
        }
    }
}
