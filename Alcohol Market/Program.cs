using System;

namespace Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiskeyPrice = double.Parse(Console.ReadLine());
            double beerL = double.Parse(Console.ReadLine());
            double wineL = double.Parse(Console.ReadLine());
            double rakiaL = double.Parse(Console.ReadLine());
            double wiskeyL = double.Parse(Console.ReadLine());

            double rakiaPrice = wiskeyPrice / 2;
            double winePrice = rakiaPrice - (0.4 * rakiaPrice);
            double beerPrice = rakiaPrice - (0.8 * rakiaPrice);

            double rakiaSum = rakiaL * rakiaPrice;
            double wineSum = wineL * winePrice;
            double beerSum = beerL * beerPrice;
            double wiskeySum = wiskeyL * wiskeyPrice;
            double totalSum = rakiaSum + wineSum + beerSum + wiskeySum;


            Console.WriteLine("{0:F2}", totalSum);
        }
    }
}
