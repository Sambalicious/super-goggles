
  /*      
            //program that count the numbers < 100 divisible by 3 without remainder
            var total = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                    total += 1;
            }
            System.Console.WriteLine(total);

        ////
program that adds number until the user types ok
            var total = 0;
            while(true)
            {               
                  System.Console.WriteLine("Enter a number");
                var input = Console.ReadLine();

                    if(input == "ok")
                    break;

                   
                    total +=Convert.ToInt32(input);

                
            }

             
                    System.Console.WriteLine(total);

                    var factorial = 1;
             System.Console.WriteLine("Enter a number");
             var input = Convert.ToInt32(Console.ReadLine());

             for (int i = input; i > 0; i--)
             {
                factorial *= i;
             }

            Console.WriteLine("The factorial of " + input + " is " + factorial);


          //program that ask the user to guess a magic number; 
             
          var i = 0;
          var random = new Random();
         var result = random.Next(1,11);
        System.Console.WriteLine(result);

         while(i <= 4)
         { 
             System.Console.WriteLine("Enter a magic number");
             var input = Convert.ToInt32(Console.ReadLine());

             if (input == result)
             {
                  System.Console.WriteLine("You won champion");
                  break;
             }
            
             else
             {
                 System.Console.WriteLine("you lost");
             }

             i++;
             
         }

            //program that finds the max number in an array of numbers
         while(true)
         {
                    System.Console.WriteLine("Enter a set of numbers");
                var input = Console.ReadLine().Trim();

                if(string.IsNullOrWhiteSpace(input))
                {
                    input.Trim();
                }
       
        var result = input.Split(",");
        var maximum = Convert.ToInt32(result[0]);
    

        foreach (var item in result)
        {
            var newNumber = Convert.ToInt32(item);
            if(newNumber > maximum)
        maximum = newNumber;
        }
          System.Console.WriteLine(maximum);
         break;
         }


         
         //length
         var numbers = new[] {3,1,9,6,7,8,1};
   //System.Console.WriteLine( numbers.Length);

      //index
       //System.Console.WriteLine(Array.IndexOf(numbers, 9)); 

    //clear()
    Array.Clear(numbers, 0, 1);
        foreach (var number in numbers)     
        {
            //System.Console.WriteLine(number);
        }
        //copy an array from one to another
var newNumbers = new int[3];
        Array.Copy(numbers, newNumbers, 3);

foreach (var i in newNumbers)
{
  //  System.Console.WriteLine(i);
}

//sorting array
Array.Sort(numbers);
foreach (var item in numbers)
    {
   // System.Console.WriteLine(item);
}
//reversing array
    Array.Reverse(numbers);
    foreach (var item in numbers)
    {
        System.Console.WriteLine(item);
    }
//List 
     var numbers = new List<int>(){1,3,4,1,5,6};
            numbers.Add(7);
             numbers.AddRange(new int[]{8,9});
             numbers.Clear();
             numbers.IndexOf(6);
             numbers.LastIndexOf(1);
             numbers.Remove(6);

            foreach (var num in numbers)
            {
                System.Console.WriteLine(num);
            } 

           System.Console.WriteLine(numbers.IndexOf(6)); 


           //program that count the number of people that likes your post

var names = new List<string>();
           while(true)
           {
               System.Console.WriteLine("Enter your name if you like this post");
               var input = Console.ReadLine();

               if(string.IsNullOrEmpty(input))
               break;

               names.Add(input);

           }

           for (int i = 0; i < names.Count; i++)
           {
                if(names.Count == 1)
               System.Console.WriteLine(names[0] + " likes your posts");
               else if(names.Count == 2)
                System.Console.WriteLine(names[0] + " and "+ names[1] + " likes your posts");
                else if(names.Count > 2)
                System.Console.WriteLine(names[0] + "," + names[1] + " and " + (names.Count-2) + " others likes your posts" );
           }

  //program that revereses name
            System.Console.WriteLine("What is your name");
            var input = Console.ReadLine();
             var reversedName = "";

        for (int i = input.Length; i > 0 ; i--)
        {
            reversedName += input[i - 1];
        }
          System.Console.WriteLine("your reversed name is " + reversedName);

        //a program that collectes unique numbers and sort them
            var uniqueNumbers = new List<int>();
              
              while (true)     
              {
                 System.Console.WriteLine("Enter 5 unique numbers");
                 var input = Console.ReadLine();
                 
                System.Console.WriteLine();
                 var result = Convert.ToInt32(input); 
                 if(!uniqueNumbers.Contains(result))
                 uniqueNumbers.Add(result);
                  else
                  {
                     System.Console.WriteLine("You previously entered this number");
                 continue;
                  }
                

                 if(uniqueNumbers.Count == 5)
                 break;
                

                

              }
              uniqueNumbers.Sort();

              foreach (var number in uniqueNumbers)
              {
                  System.Console.WriteLine(number);
              }  


                 //a program that repeatedly ask for numbers unless quit is typed
            var numbers = new List<int>();
            while(true)
            {
                  System.Console.WriteLine("Enter a number");
                    var input = Console.ReadLine();

                if(input.ToLower() == "quit")
                break;

                    var result = Convert.ToInt32(input);
                    numbers.Add(result);
            }

            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }


            //working with Date and time
            var date = new DateTime(2015,1,1);
           System.Console.WriteLine(date);

         var now = DateTime.Now;
       
         System.Console.WriteLine(now.ToLongDateString());
         System.Console.WriteLine(now.ToShortDateString());
         System.Console.WriteLine(now.ToShortTimeString());
         System.Console.WriteLine(now.ToString("yyyy-mm-dd HH:mm"));

       var today = DateTime.Today;

        //working with timespan
           var timespan = new TimeSpan(1,2,3);
            System.Console.WriteLine(timespan);
            System.Console.WriteLine(timespan.Minutes);
           
            System.Console.WriteLine(timespan.Add(TimeSpan.FromMinutes(8)));
 System.Console.WriteLine(timespan.TotalMinutes);


           var start = DateTime.Now;
           var end = start.AddMinutes(2);

           
        var span = TimeSpan.FromMinutes(10);
        System.Console.WriteLine("span: " + span);
           var duration = end - start;
           System.Console.WriteLine(duration);


           System.Console.WriteLine("parse: " + TimeSpan.Parse("1:20:30"));
          
             //wprking with string
            var fullName = "samuel Ayegbusi";
          System.Console.WriteLine(fullName.Replace("samuel", "sambalicious"));   
            fullName.ToUpper();
            fullName.ToLower();



          var names =  fullName.Split(" ");
          foreach (var name in names)
          {
              System.Console.WriteLine(name);
          }

          var builder = new StringBuilder("Hello World");

          builder
          .Append('-', 10)
          .AppendLine()
          .Append("header")
          .AppendLine()
           .Append('-', 10)
           .Replace('-', '+')
           .Remove(0, 10)
           .Insert(0, new string('-', 10));
          System.Console.WriteLine(builder);

          //a program that check for duplicates in set of numbers

            var list = new List<int>();
                var uniqueNumber = new List<int>();
            while(true)
            {
               
            
                System.Console.WriteLine("Enter a series of numbers seperated by an hyphen");
                var input = Console.ReadLine();

              var numbers =  input.Split("-");
            

              if(string.IsNullOrWhiteSpace(input))
              break;

              foreach (var number in numbers)
              {
                 list.Add(Convert.ToInt32(number));
              }

             foreach (var number in list)
             {
                  if(!uniqueNumber.Contains(number))
                  {
                      uniqueNumber.Add(number);
                  }
                  

                  else
                  {
                      System.Console.WriteLine("Duplicate :" + number);
                  }
                  
                
             }
                   break;
            
              }

              //time format program
                 public static bool NewMethod(string input)
        {
            
            

            var time = input.Split(":");
            var inValid = "Invalid Time";
            var valid =  "valid time format, correct!";

            if (string.IsNullOrWhiteSpace(input))
                return false;

            if (time.Length != 2)
               return ;

            else if (Convert.ToInt32(time[0]) >= 0 || Convert.ToInt32(time[0]) <= 23 && Convert.ToInt32(time[1]) >= 0 || Convert.ToInt32(time[1]) <= 60)
                return true;
        }

        //method that covert word to pascal case
        
        public static string PascalWordConverter(string input)
        {
             var result = "";

           var words = input.ToLower().Split(" ");
           var lists = new List<string>();

           foreach (var word in words)
           {
              result += char.ToUpper(word[0]) + word.ToLower().Substring(1); 
            
           }
              return result
        }

        //a method that count vowels
        
        public static int CountVowels(string words)
        {
             var total =0;
            var vowels = new List<char>(){'a','e', 'i', 'o', 'u'};

            foreach (var word in words)
            {
                if(vowels.Contains(word))
                total++;
            }
           
            return total;
        }


          static void usePoints()
        {
             try
            {
                 var point = new Point(10, 20);
                point.Move(new Point(10,20));
                System.Console.WriteLine("point is at {0} and {1} ", point.X, point.Y);

                point.Move(100,200);
                System.Console.WriteLine("point is at {0} and {1} ", point.X, point.Y);

                point.Move(null);
            }
            catch (System.Exception)
            {
                
               System.Console.WriteLine("unexpected error");;
            }
        }


     */        
        