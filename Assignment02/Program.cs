using System;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            var s1 = new Student
            {
                Id = 1,
                GivenName = "Mohammad",
                SurName = "Hasham",
                StartDate = new DateTime(2021, 09, 22, 00, 00, 00),
                EndDate = new DateTime(2024, 06, 24, 00, 00, 00),
                GraduationDate = new DateTime(2024, 06, 22, 00, 00, 00)
            };
            var s2 = new Student.ImmutableStudent(1,"Mohammad","Hasham", Status.Active,new DateTime(2021, 09, 22, 00, 00, 00), new DateTime(2024, 06, 24, 00, 00, 00),new DateTime(2024, 06, 22, 00, 00, 00));
            var s3 = s2;
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s2.Equals(s3));
        }
    }
}
