﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02OperacjeNaNapisach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string napis = "ala ma kota";
                          //012345678910
            int dlugosc = napis.Length; //11

            /* komentarz
             * wielo
             * wierszoy
             */

            Console.WriteLine(dlugosc);

            // F5 uruchommienie aktywnego programu 

            string s1 = napis.Substring(4); // ma kota

            string s2 = napis.Substring(4, 2); // ma


            Console.WriteLine(s1);

            bool czyZawiera = napis.Contains("ma"); // czy napis zawiera słowo "ma"

            bool b1 = true;
            bool b2 = false;


            string naMale = napis.ToLower();
            string naDuze = napis.ToUpper();

            // konkatenajca (łaczenie ciągów tekstowych)

            string s3 = "ala" + "ma" + "kota";
            //alamakota

            string s4 = napis + " i kota";

            string s5 = "ala".ToUpper();

            string s6 = "ala";
            s6 = s6.ToUpper(); // podamina wartości na nową

            s6.ToLower(); // tutaj "ALA" cały czas bedzie z duzej literki 

            string s7 = napis.Replace("ma", "bedzie miala");
            // ala bedzie miala kota 

            int pozycja =  napis.IndexOf("ma");
            // 4

            Console.ReadKey();


        }
    }
}
