using System;
using Xunit;
using src;

namespace test
{
    public class BookTests
    {
        [Fact]
        public void CheckStatistics()
        {
            //arrange
            var book = new BookInstance();
            SetGrades(book);

            Statistics expected = new Statistics();
            expected.Total = 325.0;
            expected.Average = 81.25;
            expected.High = 90.0;
            expected.Low = 70.0;

            Statistics actual = book.GetStatistics();

            //act
            //assert
            Assert.Equal(expected.High, actual.High);
            Assert.Equal(expected.Low, actual.Low);
            Assert.Equal(expected.Average, actual.Average);
            Assert.Equal(expected.Total, actual.Total);
        }

         [Fact]
        public void CheckNoStatistics()
        {
            //arrange
            var book = new BookInstance();

            Statistics expected = new Statistics();
            expected.Total = 0.0;
            expected.Average = 0.0;
            expected.High = 0.0;
            expected.Low = 0.0;

            Statistics actual = book.GetStatistics();

            //act
            //assert
            Assert.Equal(expected.High, actual.High);
            Assert.Equal(expected.Low, actual.Low);
            Assert.Equal(expected.Average, actual.Average);
            Assert.Equal(expected.Total, actual.Total);
        }
        public void SetGrades(BookInstance book)
        {
            book.AddGrade(90.0);
            book.AddGrade(85.0);
            book.AddGrade(80.0);
            book.AddGrade(70.0);
        }
    }
}
