using System;

namespace Shapes_Volume
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
                    case "Cube":
                        Cube.side_lenght = double.Parse(words[1]);
                        Console.WriteLine(VolumeCalculator.VolumeCube(Cube.side_lenght));
                        break;

                    case "Cylinder":
                        Cylinder.radius = double.Parse(words[1]);
                        Cylinder.height = double.Parse(words[2]);
                        Console.WriteLine(VolumeCalculator.VolumeCylinder(Cylinder.radius,Cylinder.height));
                        break;

                    case "TrianglePrism":
                        TriangularPrism.base_side = double.Parse(words[1]);
                        TriangularPrism.height_from_base = double.Parse(words[2]);
                        TriangularPrism.lenght = double.Parse(words[3]);
                        Console.WriteLine(VolumeCalculator.VolumeTrianglePrism(TriangularPrism.base_side,TriangularPrism.height_from_base,TriangularPrism.lenght));
                        break;

                    default: Console.WriteLine("Nope! Try Again!"); break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
