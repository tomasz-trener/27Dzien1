using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12InnePetle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 While 

            while (true)
            {
                if (true)
                {
                    break;
                }
            }

            // 2 DoWhile

            string zdanie = "ala ma kota";
                           //012345678910
            int i = 0;
            // wypisz kolejne znaki w zdaniu 
            // (bo zakadamy, ze nasze zdanie przynajmniej 1 znak bedzie zawierac)
            do
            {
                Console.WriteLine(zdanie.Substring(i,1));
                i++;
            } while (i < zdanie.Length); // sorwadzany czy nizeny usc dakej 
                                         // do-while wykona sie przynajmniej 1 raz 

            // 3 for

           

            for (int j = 0; j < zdanie.Length; j+=2)
            {
                Console.WriteLine(zdanie.Substring(j,1));
            }

            // mozemy modyfikowac parametry petli for 
            for (int j = zdanie.Length-1; j >=0 ; j--)
                Console.WriteLine(zdanie.Substring(j, 1));

            // staramy sie unikac >= lub <=
            for (int j = zdanie.Length - 1; j > -1; j--)
                Console.WriteLine(zdanie.Substring(j, 1));


            // czesto bedzie tak, ze bedzie iterowac po wsztykich elemtach dane zbioru 

            foreach (var literka in zdanie)
            {
                Console.WriteLine(literka);
            }

            // w kazdej z petli mozemy uzyc słów: break (zakoncz petle)  oraz continue (przejdz do nastepnej iteracji)

            foreach (var literka in zdanie)
            {
                if (literka=='n')
                {
                    continue; // przejdz do nastepnej iteracji 
                }
                Console.WriteLine(literka);
            }

            Console.ReadKey();

            // podsumowanie: 
            // while, do.. while, for oraz foreach. 
            // break, continue 
        }
    }
}
