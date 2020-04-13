using System;

namespace Animal_Clinic
{
    class Program
    {
        public static int contador=2;
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "End")
            {
                for (int i = 1; i < contador; i++)
                {
                    string[] words = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    if (words[0] == "End")
                    {
                        Console.WriteLine("Total healed animals: " + AnimalClinic.healedAnimalsCount);
                        Console.WriteLine("Total healed animals: " + AnimalClinic.rehabilitedAnimalsCount);
                        command = Console.ReadLine();
                        if (command == "heal")
                        {
                            Console.WriteLine("ta aqui");
                        }
                    }
                    else

                    switch (words[2])
                    {
                        case "heal":
                            Animal.name = (words[0]);
                            Animal.breed = (words[1]);
                            AnimalClinic.healedAnimalsCount += 1;
                            Console.WriteLine("Patient " + AnimalClinic.patientId+i + ": [" + Animal.name + "(" + Animal.breed + ")] has been healed");
                            break;

                        case "rehabilited":
                            Animal.name = (words[0]);
                            Animal.breed = (words[1]);
                            AnimalClinic.rehabilitedAnimalsCount += 1;
                            Console.WriteLine("Patient " + AnimalClinic.patientId + i + ": [" + Animal.name + "(" + Animal.breed + ")] has been rehabilited");
                            break;

                        default: Console.WriteLine("Nope! Try Again!"); break;
                            
                    }
                    contador++;
                    command = Console.ReadLine();
                }
            }

            

        }
    }
}
