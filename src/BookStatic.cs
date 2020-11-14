using System.Collections.Generic;

namespace src
{
    internal class BookStatic
    {
        static List<double> Grades;

        public BookStatic()
        {
            Grades = new List<double>();
        }

        public static void AddGrade(double grade)
        {
            Grades.Add(grade);
        }

        public double GetAverage()
        {
            if (Grades.Count > 0) //Without this we would get NaN when Grades.Count is 0
            {
                return GetTotal() / Grades.Count;
            }
            return 0;
        }

        public double GetTotal()
        {
            double total = 0f;

            foreach (var n in Grades)
            {
                total += n;
            }
            return total;
        }
        public string OutputTotal()
        {
            return $"Total is {GetTotal()}";
        }

        public string OutputAverage()
        {
            return $"Average is {GetAverage()}";
        }

    }
}