using System;

namespace BasicMath
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] words = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (words[0])
                {
                    case "Sum":
                        Console.WriteLine(Maths.Sum(double.Parse(words[1]), double.Parse(words[2])));
                        break;

                    case "Subtract":
                        Console.WriteLine(Maths.Subtract(double.Parse(words[1]), double.Parse(words[2])));
                        break;

                    case "Multiply":
                        Console.WriteLine(Maths.Multiply(double.Parse(words[1]), double.Parse(words[2])));
                        break;

                    case "Devide":
                        Console.WriteLine(Maths.Devide(double.Parse(words[1]), double.Parse(words[2])));
                        break;

                    case "Percentage":
                        Console.WriteLine(Maths.Percentage(double.Parse(words[1]), double.Parse(words[2])));
                        break;

                    default: Console.WriteLine("Nope! Try Again!"); break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
