namespace Basics

{
    public class Consumer 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);
            if(rating == 0)
            System.Console.WriteLine("promoted to level 1");
            else
            System.Console.WriteLine("Promoted to level 2");
        }
        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
 }