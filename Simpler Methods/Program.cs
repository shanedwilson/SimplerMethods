using System;
using System.Collections.Generic;

namespace Simpler_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var prayingMantis = new Bug("Praying Mantis", "Religiosa",
                new List<string> { "people" },
                new List<string> { "moths", "mosquitoes", "roaches", "flies", "aphids" });

            Console.WriteLine(prayingMantis.PreyList());
            Console.WriteLine(prayingMantis.PredatorList());
            Console.WriteLine(prayingMantis.Eat("people"));
            Console.WriteLine(prayingMantis.Eat("flies"));
            Console.ReadKey();
        }
    }

}
