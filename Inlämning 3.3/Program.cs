using System;
using System.Numerics;
namespace inlämning
{
    class Program
    {
        static void Main(string[] args)
        {
            const int timpris = 80;

            const int maxPrisPerDag = 950;

            Console.WriteLine("Hur många timmar vill du låna en bil för?");
            int timmar =  int.Parse(Console.ReadLine());

            int totalkostnad = timmar * timpris;

            if (totalkostnad > maxPrisPerDag)
            {
                totalkostnad = maxPrisPerDag;
                Console.WriteLine("Kostnaden för {0} timmar blir: {1} kronor");
            }
        }
    }
}
