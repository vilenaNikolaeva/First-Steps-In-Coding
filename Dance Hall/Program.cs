using System;

namespace Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallLenght = double.Parse(Console.ReadLine());
            double hallWight = double.Parse(Console.ReadLine());
            double wardrobeCount = double.Parse(Console.ReadLine());

            double hallArea = (hallLenght * 100) * (hallWight * 100);
            double wardrobeArea = (wardrobeCount * 100) * (wardrobeCount * 100)
                ;
            double benchSide = hallArea / 10;
            double freeSpace = hallArea - wardrobeArea - benchSide;

            double dancers = Math.Floor(freeSpace / 7040);
            Console.WriteLine(dancers);

        }
    }
}
