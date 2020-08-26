namespace Basics

{
    public class Vehicle
   {
        private readonly string _registrationNumber;

       public Vehicle(string registrationNumber)
       {
            _registrationNumber = registrationNumber;
            System.Console.WriteLine("Vehicle initialized with the following registration number" + registrationNumber);
        }
   }
 }