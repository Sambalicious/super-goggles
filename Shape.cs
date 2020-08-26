namespace Basics

{
    
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            System.Console.WriteLine("shape copied to clipboard");
        }

        public void Select()
        {
            System.Console.WriteLine("shape Selected");
        }
   

        public abstract void Draw();
       
    }
 }