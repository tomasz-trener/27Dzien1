using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10Petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 0;

            while (k < 10)
            {
                k++;
                Console.WriteLine(k);
            }

            Console.ReadKey();

            // zastanwomy sie nad problemem z zadnia p04 

            string rownanie = "10 200 400";
                             //0123456

            int pozycjaSpacji = -1;
            int i = 0;
            while (i< rownanie.Length)
            {
                if (rownanie.Substring(i, 1) == " ")
                    pozycjaSpacji = i;
                i++;
            }

            // to by algorytm ktory dziala jak indexOf ale znajduje ostatnia spacje 
            // nasz algorytm to odpowiednik gunkcji LastIndexOf 
            //rownanie.LastIndexOf()


            //a co by bylo gdybysmy chcieli zrobic "first occeurance" 
            pozycjaSpacji = -1;
            i = 0;
            while (i < rownanie.Length)
            {
                if (rownanie[i] == ' ' )
                {
                    pozycjaSpacji = i;
                    break; // przerywa petle 
                }
                   
                i++;
            }


            string napis = "ala ma kota";
            char znak = 'n';


        }
    }
}
