using System;
namespace Basics
{
    public class StackoverflowPost
    {
        public string Title { get; set; }
        public string Description { get; set; }

        private DateTime _timeCreated = DateTime.Now;
        private int _vote;

        public int UpVote()
        {
            return _vote++;
        }

        public int DownVote()
        {
            return _vote -=1;
        }

        public void TotalDetails()
        {
          
            System.Console.WriteLine("Total votes: "+ _vote);
            System.Console.WriteLine("Post Title: " + Title);
            System.Console.WriteLine("Post Description: "+ Description);
            System.Console.WriteLine("Time Created: "+ _timeCreated);
            System.Console.WriteLine();
            
        }

    }
}