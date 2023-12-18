using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11ZadaniePetle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wczytaj zdanie");
            string zdanie = Console.ReadLine();

            Console.WriteLine("Wczytaj wyraz");
            string wyraz = Console.ReadLine();

            //ala ma kota i ma psa
            //                  ma

            int i = 0;
            int licznik = 0;

            while (i <= zdanie.Length - wyraz.Length)
            {
                string podciag = zdanie.Substring(i, wyraz.Length);
                if (podciag == wyraz)
                    licznik++;
                i++;
            }

            string raport = "Slowo/znak '{0}' wystepuje w podanym zdaniu {1} razy";
            Console.WriteLine(string.Format(raport,wyraz,licznik));
            Console.ReadKey();

        }
    }
}
