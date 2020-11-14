using System;
using System.Collections.Generic;

namespace src
{
    public class BookInstance
    {
        public BookInstance()
        {
            Grades = new List<double>(); // intialization expression of the field property
        }

        List<double> Grades;

        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }

        public double GetAverage()
        {
            if (Grades.Count > 0)
            {
                return GetTotal() / Grades.Count;
            }
            return 0;
        }

        public double GetHighestValue()
        {
            double HighGrade = double.MinValue;
            foreach (var n in Grades)
            {
                HighGrade = Math.Max(n, HighGrade);
            }
            if(HighGrade == double.MinValue)
            {
                HighGrade = 0.0;
            }
            return HighGrade;
        }
        public double GetLowestValue()
        {
            double LowGrade = double.MaxValue;
            foreach (var n in Grades)
            {
                LowGrade = Math.Min(n, LowGrade);
            }
            if(LowGrade == double.MaxValue)
            {
                LowGrade = 0.0;
            }
            return LowGrade;
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

        public Statistics GetStatistics()
        {
            Statistics stats = new Statistics();
            stats.Average = this.GetAverage();
            stats.High = this.GetHighestValue();
            stats.Low = this.GetLowestValue();
            stats.Total = this.GetTotal();

            return stats;
        }

        public void ShowStatistics()
        {
            Console.WriteLine($"Total is {this.GetTotal()}");
            Console.WriteLine($"Average is {this.GetAverage():N2}");
            Console.WriteLine($"Highest Value is {this.GetHighestValue()}");
            Console.WriteLine($"Lowest Value is {this.GetLowestValue()}");
        }
    }
}
