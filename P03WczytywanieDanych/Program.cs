using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03WczytywanieDanych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj jak się nazywasz");
            string imie = Console.ReadLine(); //.ToUpper() można od razu

            imie = imie.ToUpper();
            Console.WriteLine(imie);

            Console.WriteLine("Podaj wiek");
            string wiek = Console.ReadLine();

            //wiek = wiek + 1; // + oznacza konkatenacja. 30+1 = 301

            int wiekInt = Convert.ToInt32(wiek) + 1;

            Console.WriteLine("za rok bedziesz mial " + wiekInt + " lat");

            ///Console.WriteLine("za rok bedziesz mial " + Convert.ToString(wiekInt)+ " lat");
            ///

            // konkatenacja ciagów tekstowych wykouje automatyczna konwersje dowolnego typu na string 

            Console.WriteLine(wiekInt);
            Console.ReadKey();
        }
    }
}
