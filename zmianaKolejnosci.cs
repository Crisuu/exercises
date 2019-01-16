using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odwrocNapis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz słowo:");
            string slowo = Console.ReadLine();
            Console.WriteLine(odwrocNapis(slowo, 'a'));
            Console.ReadKey();
        }
        static string odwrocNapis(string napis, char wyklucz)
        {
            StringBuilder sb = new StringBuilder();

                    for (int i = napis.Length - 1; i >= 0; i--)
                    {
                        sb.Append(napis[i]);
                    }
            return sb.ToString();
        }
    }
    
}
