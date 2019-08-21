using System;
using Xunit;
using GradeBook;

namespace GradeBook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Given
            Book book = new Book();

            // When
            book.AddGrade(3);
            book.AddGrade(6);
            book.AddGrade(9);

            // Then
            Assert.Equal(3, book.MinGrade());
            Assert.Equal(9, book.MaxGrade());
            Assert.Equal(6, book.Average());
        }
    }
}
