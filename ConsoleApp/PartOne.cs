using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class PartOne
    {
        private int DoubleTrouble(int x) //prywatna funkcja odpowiedzialna za znalezienie największej, mieszczącej się potęgi liczby 2 
        {
            int y = 2;
            if (x < y) //Obsługa wyjątku 2^0 = 1
            {
                return 1;
            }
            else
            {
                while (x >= y * 2) //Pętla sprawdzajaca czy dana potęga jeszcze sie mieści w analizowanej liczbie
                {
                    y = y * 2;
                }
            }
            return y;
        }

        public int Calcumulator(int number) //główna funkcja klasy zwracajaca ilość potęg których suma tworzy daną liczbę 
        {
            int holder = number;
            int counter = 0; 
            while (holder > 0)
            {
                int deductor = DoubleTrouble(holder); //deductor to zmienna do której jest przypisana liczba z aktualnie największą potęgą 
                holder = holder - deductor; //od holdera (liczby analizowanej na początku) odejmujemy deductor czyli największą aktualną potęgę
                counter++;
            }
            return counter;
        }
    }
}
