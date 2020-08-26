using System;
namespace Basics
{
    class Person 
    {
        public string Name { get; set; }
        public string userName { get; set; }


        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }


     public DateTime Birthdate { get; private set; }

     public int Age
     {
         get{
              var timespan = DateTime.Today - Birthdate;
                 var years = timespan.Days / 365;
                return years;
               }
     }


    }
}