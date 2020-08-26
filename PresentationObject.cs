namespace Basics

{
    public class PresentationObject
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public void Copy()
        {
            System.Console.WriteLine("object copied to clipboard");
        }

        public void Duplicate()
        {
            System.Console.WriteLine("Object was dupliacted");
        }
    }
 }