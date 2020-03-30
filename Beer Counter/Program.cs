using System;

namespace Beer_Counter
{
    class Program
    {
         
        static void Main(string[] args)
        {

            string command = Console.ReadLine();

            while (command != "End")
            {
                
                
                    string[] words = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    Console.WriteLine(counter.BuyBeer(int.Parse(words[0])));
                    Console.WriteLine(counter.DrinkBeer(int.Parse(words[1])));

                   if(counter.beerInStock < 1)
                    {
                    Console.WriteLine("Seu bêbado não tens vergonha?");
                    }
                    
                
               command = Console.ReadLine();
            }
            
        }
    }
}
