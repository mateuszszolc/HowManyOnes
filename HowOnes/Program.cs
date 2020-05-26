using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");
            int n = int.Parse(Console.ReadLine());
            List<string> strList = Enumerable.Range(1, n).ToList().ConvertAll(Convert.ToString);
            int outcome = 0;
            foreach(var item in strList)
            {
                outcome += item.Count(j => j == '1');
            }
            Console.WriteLine(outcome);
            Console.ReadKey();
        }
    }
}
