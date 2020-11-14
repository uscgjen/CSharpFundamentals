using System;
using Xunit;
using src;

namespace test
{
    public class BookTypeTests
    {
        [Fact]
        public void VariablesMultipleInstances()
        {
            //arrange
            var book = GetBook();
            var book2 = GetBook();

            //act
            //assert
            Assert.NotSame(book2, book);
        }

        [Fact]
        public void VariablesSameInstances()
        {
            //arrange
            var book = GetBook();
            var book2 = book;

            //act
            //assert
            Assert.Same(book2, book);
        }

        [Fact]
        public void ValueTypeCheck()
        {
            int n = 3;
            SetValue(n); 

            Assert.Equal(3, n);
        }
        
        public BookInstance GetBook()
        {
            return new BookInstance();
        }

public void SetValue(int number)
{
     number = 42;
}
    }
}
