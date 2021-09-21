using System;
using Xunit;
using Assignment02;

namespace Assignment02.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Given_a_student_prints_description()
        {
            // TODO: Fix the namespace, so you can call the class and its methods.
            //Given
            var s1 = new Assignment02.Student() 
            {
                Id = 1,
                GivenName = "Mohammad",
                Surname = "Hasham",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                GraduationDate = DateTime.Now
            };

            //When
            var expected = "1: Mohammad Hasham | start date: 21-09-2021 00:00:00 | end date: 21-09-2021 00:00:00 | graduation date: 21-09-2021 00:00:00."; 
            var actual = s1.ToString();

            //Then
            Assert.Equal(expected, actual);
        }
    }
}
