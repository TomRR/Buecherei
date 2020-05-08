using System;
using System.Collections.Generic;

namespace Buecherei
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AusleihbaresMedium> medienListe = new List<AusleihbaresMedium>() {

            //1
            new AusleihbaresMedium { istAusgeliehen = true,},
            //2
            new AusleihbaresMedium { istAusgeliehen = false,},

            //3
            new Video() { istAusgeliehen = true,},
            //4
            new Video() { istAusgeliehen = false,  },

            //5
            new Software { istAusgeliehen = true },
            //6
            new Software { istAusgeliehen = false},

            //7
            new Buch { istAusgeliehen = false, InReparatur = false },
            //8
            new Buch { istAusgeliehen = false,InReparatur = true },
            //9
            new Buch { istAusgeliehen = true, InReparatur = false },
            //10
            new Buch { istAusgeliehen = true, InReparatur = true },
        };
            int i = 1;
            foreach (AusleihbaresMedium ausleihbares in medienListe)
            {
                Console.WriteLine(i);
                Console.WriteLine("kann es 7 Tage lang ausgeliehen werden: " + ausleihbares.KannAusgeliehenWerden(DateTime.Now.AddDays(7)));
                Console.WriteLine("kann es 9 Tage lang ausgeliehen werden: " + ausleihbares.KannAusgeliehenWerden(DateTime.Now.AddDays(9)));
                Console.WriteLine("kann es 27 Tage lang ausgeliehen werden: " + ausleihbares.KannAusgeliehenWerden(DateTime.Now.AddDays(27)));
                Console.WriteLine("kann es 50 Tage lang ausgeliehen werden: " + ausleihbares.KannAusgeliehenWerden(DateTime.Now.AddDays(50)));
                Console.WriteLine("");
                i++;
            }
        }
    }
}
