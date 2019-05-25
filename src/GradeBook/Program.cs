using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Bhavika's Grade Book");
            // book.AddGrade(89.1);
            //book.AddGrade(90.5);
            // var grades = new List<double> {12.7, 10.3, 6.11, 4.1};
            //grades.Add(56.1);
            //book.AddGrade(77.5);
            while(true)
            {
                Console.WriteLine("Enter grade or 'q' to quit");
                var input = Console.ReadLine();
                if(input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                   // throw;
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                   // throw;
                }
                finally
                {
                    //...
                    Console.WriteLine("*****");

                }

            }
            var stats = book.GetStatistics();
         //   book.Name = "";
        // cannot be changes because "private set".
            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"Lowest grade: {stats.Low}");
            Console.WriteLine($"Highest grade: {stats.High}");
            Console.WriteLine($"result: {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
