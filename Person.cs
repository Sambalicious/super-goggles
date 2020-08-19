namespace Basics
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void introduce()
        {
            System.Console.WriteLine("my name is " + firstName + " " + lastName);
        }

    }
}