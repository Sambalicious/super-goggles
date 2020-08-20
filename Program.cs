using System;

namespace Basics
{
    class Program 
    {
        static void Main (string[] args) 
        {
            
            var total = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                    total += 1;
            }
            System.Console.WriteLine(total);
           
             
        }

    }
   }
