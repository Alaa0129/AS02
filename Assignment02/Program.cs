using System;
using static Assignment02.student;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new student() 
            {
                Id = 1,
                GivenName = "Mohammad",
                Surname = "Hasham",
                StartDate = DateTime.Today,
                EndDate = DateTime.Today,
                GraduationDate = DateTime.Today
            };

            Console.WriteLine(s1);
        }
    }
}
