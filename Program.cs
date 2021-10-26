using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
         Random tense = new Random();
         int returnvalue = tense.Next(1, 100);

         Console.WriteLine("Type a number between 1 and 100.");
         int web = int.Parse(Console.ReadLine());
         int counter = 1;

         while(web != returnvalue)
         {
             counter=counter + 1;

             if(web < returnvalue)
             { 
                 Console.WriteLine("The number is too small, try again.");
                 web = int.Parse(Console.ReadLine());

             }

             if(web > returnvalue)
             {
                 Console.WriteLine("The number is too large, try again.");
                 web = int.Parse(Console.ReadLine());
             }
         }
           Console.WriteLine("Good Job!" + " It took you " + counter + " tries to guess the number. ");
        }
    }
}


