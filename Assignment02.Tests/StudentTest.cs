using System;
using Xunit;
using Assignment02;

namespace Assignment02.Tests
{
    public class StudentTest
    {
        [Fact]
        public void Given_a_student_prints_description()
        {
            //Given
            var s1 = new Student
            {
                Id = 1,
                GivenName = "Mohammad",
                Surname = "Hasham",
                StartDate = 22-08-2021,
                EndDate = 22-06-2024,
                GraduationDate = 22-06-2024
            };

            //When
            var expected = "1: Mohammad Hasham | start date: 22-09-2021 00:00:00 | end date: 22-09-2021 00:00:00 | graduation date: 22-09-2021 00:00:00."; 
            var actual = s1.ToString();

            //Then
            Assert.Equal(expected, actual);
        }
    }
}
