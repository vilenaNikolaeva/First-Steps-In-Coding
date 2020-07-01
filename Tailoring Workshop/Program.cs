using System;

namespace Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double tableLenght = double.Parse(Console.ReadLine());
            double tableWight = double.Parse(Console.ReadLine());

            double tableCountArea = tables * (tableLenght + 2 * 0.30) * (tableWight + 2 * 0.30);

            double tableTopperArea = tables * (tableLenght / 2) * (tableWight / 2);

            double tableCountAreaUSD = tableCountArea * 7;
            double tableTopperAreaUSD = tableTopperArea * 9;

            double tableCountAreaBGN = tableCountAreaUSD * 1.85;
            double tableTopperAreaBGN = tableTopperAreaUSD * 1.85;

            Console.WriteLine("{0:F2}", tableCountAreaBGN);
            Console.WriteLine("{0:F2}", tableCountAreaUSD);

        }
    }
}
