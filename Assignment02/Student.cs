using System;

namespace Assignment02
{
    public class student 
    {
        public int Id {get; set;}
        public string GivenName {get; set;}
        public string Surname {get; set;}
        public Status Status {get;}
        public DateTime StartDate {get; set;}
        public DateTime EndDate {get; set;}
        public DateTime GraduationDate {get; set;}
        

        // TODO: Add the Enum "status" to the print method
        public override string ToString() 
        {
            return Id + ": " + GivenName + " " + Surname + " | start date: " + StartDate + " | end date: " + EndDate + " | graduation date: " + GraduationDate + ".";
        } 

    }


}