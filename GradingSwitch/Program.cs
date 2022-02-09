using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja sai;
            //kui kasutaja sai A, konsool kuvab "Suurepärane!";
            //kui B, konsool kuvab "Väga hea!";
            //kui C, konsool kuvab "Hea!";
            //kui D, konsool kuvab "Rahuldav!";
            //kui E, konsool kuvab "Kasin!";
            //kui F, konsool kuvab "Puudulik!;
            //kui kasutaja sisestab midagi muud, siis konsool kuvab "Vale väärtus.";

            //kasutame SWITCH

            Console.WriteLine("Sisesta oma tulemus:");
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userResult)
            {
                case 'A':
                    Console.WriteLine("Suurepärane!");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav!");
                    break;
                case 'E':
                    Console.WriteLine("Kasin!");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik!");
                    break;
                default:
                    Console.WriteLine("Vale väärtus.");
                    break;
                    
            }
        }
    }
}
