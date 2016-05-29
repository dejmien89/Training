using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> miesiace = new Dictionary<string, int>()
            {
                {"Styczeń", 1},
                {"Luty",2},
                {"Marzec",3},
                {"Kwiecień",4},
                {"Maj",5},
                {"Czerwiec",6}
            };

            List<string> miesiaceParzyste = miesiace.Select(x => x.Key).ToList<string>();

            Console.WriteLine("Dziś jest: " + DateTime.Today + (3 - 2 + 7));
        }


    }
}
