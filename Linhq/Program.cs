using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linhq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "A", "A", "A", "A", "B", "B", "B", "C", "D" };

            var duplicates = list.GroupBy(x => x)
                       .Where(g => g.Count() == 1)
                       .Select(y => new {y.Key})
                       .ToList();

            foreach (var i in duplicates)
            {
                Console.WriteLine(i.Key);
            }

            Console.ReadLine();

        }
    }
}
