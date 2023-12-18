using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14ZadanieKalkulatorBMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoja wage w kilogramach");
            int waga = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj swój wzrost w centymetrach");
            double wzrost = Convert.ToInt32(Console.ReadLine());

            int a = 10 / 3;
            Console.WriteLine(a);
            double b = Convert.ToDouble(10) / 3;
            Console.WriteLine(b);

            // double bmi = Convert.ToDouble(waga) / (wzrost/100 * wzrost/100);
            double bmi = Convert.ToDouble(waga) / Math.Pow(wzrost/100,2);

            Console.WriteLine($"Twoje BMI wynosi {bmi:F2}"); // F2 oznacza sformatowanie danej liczby do 2 miejsc po przecinku 
            //Console.WriteLine($"Twoje BMI wynosi {bmi:0.000}"); // a tak np do 3 miejsc po przeciku 

            if (bmi < 18.5)
                Console.WriteLine("Masz niedowage");
            else if (bmi < 25)
                Console.WriteLine("Twoja waga jest w normie");
            else if (bmi < 25)
                Console.WriteLine("Twoja waga jest w normie");
            else if (bmi < 30)
                Console.WriteLine("Masz nadwage");
            else if (bmi < 35)
                Console.WriteLine("Masz Otyłość I stopnia");
            else if (bmi < 40)
                Console.WriteLine("Masz Otyłość II stopnia (kliniczna)");
            else
                Console.WriteLine("Masz Otyłość III stopnia (ekstremalna)");

            Console.ReadKey();

        }
    }
}
