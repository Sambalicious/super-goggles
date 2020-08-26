namespace Basics

{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            System.Console.WriteLine("Car is being intialized with the following reg Number: " + registrationNumber);
        }
    }
 }