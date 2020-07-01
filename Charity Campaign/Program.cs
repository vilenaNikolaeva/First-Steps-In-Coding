using System;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysNum = int.Parse(Console.ReadLine());
            int confectionerNUm = int.Parse(Console.ReadLine());
            int cakesNum = int.Parse(Console.ReadLine());
            double goftersNum = double.Parse(Console.ReadLine());
            double pancakesNum = double.Parse(Console.ReadLine());

            int cakesPrice = (cakesNum * 45);
            double goftersPrice = (goftersNum * 5.80);
            double pancakesPrice = (pancakesNum * 3.20);

            double totalByDAy = (cakesPrice + goftersPrice + pancakesPrice) * confectionerNUm;
            double campaignSum = totalByDAy * daysNum;
            double totalSum = campaignSum - (campaignSum / 8);


            Console.WriteLine("{0:F2}", totalSum);

        }
    }
}
