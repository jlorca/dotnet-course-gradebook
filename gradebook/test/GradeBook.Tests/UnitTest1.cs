using System;
using Xunit;
using GradeBook;

namespace GradeBook.Tests
{
    public class UnitTest1
    {   
        [Fact]
        public void AssertStatistics()
        {
            // Given
            Book book = new Book();
            book.AddGrade(3);
            book.AddGrade(6);
            book.AddGrade(9);

            // When
            double minGrade = book.MinGrade();
            double maxGrade = book.MaxGrade();
            double average = book.Average();

            // Then
            Assert.Equal(3, minGrade);
            Assert.Equal(9, maxGrade);
            Assert.Equal(6, average);
        }

        [Fact]
        public void AssertReferences()
        {
            //Given
            Book book1 = new Book();
            book1.AddGrade(3);

            //When
            Book book2 = new Book();
            Book book3 = book1;
            
            //Then
            Assert.False(Object.ReferenceEquals(book1, book2));
            Assert.True(Object.ReferenceEquals(book1, book3));
        }
    }
}
