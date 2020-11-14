using System;
using System.Collections.Generic;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new BookInstance();
            book.AddGrade(67.8);
            book.AddGrade(75.8);
            book.AddGrade(97.6);
            book.ShowStatistics();

            // ArrayMethod();
            // ListMethod();
            // StaticMethod();

            var foo = "Hello"; //variable declaration
            Console.WriteLine(string.Format("{0} World!", foo));
            if (args.Length > 0) //if statement
            {
                Console.WriteLine("Whats up args[0]");  //statement invoking the console.writeline method
            }

            Console.WriteLine("");
            Console.WriteLine("______________________________");
            Console.WriteLine("Coding notes");
            Console.WriteLine("Beautify code in VS Code by using Shift Option F ");
            Console.WriteLine("Double is more precise than Float");
            Console.WriteLine("Command period will show possible fixes for compiler errors");
            Console.WriteLine("Encapsulation = hide the complexity of the program with Book class");
            Console.WriteLine("Access modifiers - aka public, private");
            Console.WriteLine("Static objects are associated to the class not an instance of the object");
            Console.WriteLine("If we made addgrades method and grades list static = we would only have one list to the program rather than allow multiple instances - see staticBook.");
            Console.WriteLine("Struct is value type - class is reference type.");
            Console.WriteLine("Struct examples DateTime, Int32, Double");


            Console.WriteLine("");
            Console.WriteLine("______________________________");
            Console.WriteLine("Action Item notes");
            Console.WriteLine("TODO Find how to comment code in VS Code for Mac");
        }

        private static void ListMethod()
        {
            List<double> grades = new List<double>() { 89.2, 74.0, 98.7, 45.3 };
            grades.Add(78.2);

            double result = 0f;
            double average = 0f;

            foreach (var n in grades)
            {
                result += n;
            }
            average = result / grades.Count;

            Console.WriteLine($"Result of adding grades: {result:N2}"); // N2 formats with 2 digits after decimal point
            Console.WriteLine($"Average of grades: {average:N2}");

        }

        private static void ArrayMethod()
        {
            float a = 34.1f;
            float b = 43.8f;
            float c = 10.5f;

            double[] numbers = { a, b, c };
            double result = 0f;
            double average = 0f;

            foreach (var n in numbers)
            {
                result += n;
            }

            average = result / numbers.Length;

            Console.WriteLine($"Result of adding two floats: {a + b}");
            Console.WriteLine($"Result of adding array floats: {result}");
            Console.WriteLine(string.Format("Average of array floats: {0}", average));

        }

        private static void StaticMethod()
        {
            var book2 = new BookStatic();
            BookStatic.AddGrade(43.5);
            BookStatic.AddGrade(32.9);
            Console.WriteLine("Book2" + book2.OutputTotal());
            Console.WriteLine("Book2" + book2.OutputAverage());

            var book3 = new BookStatic(); //this resets the Static Book Grades List for both Book 2 and Book 3.
            Console.WriteLine("Book3" + book3.OutputTotal());
            Console.WriteLine("Book3" + book3.OutputAverage());

            BookStatic.AddGrade(98.1);
            Console.WriteLine("Book2" + book2.OutputTotal());
            Console.WriteLine("Book2" + book2.OutputAverage());
            Console.WriteLine("Book3" + book3.OutputTotal());
            Console.WriteLine("Book3" + book3.OutputAverage());
        }
    }
}
