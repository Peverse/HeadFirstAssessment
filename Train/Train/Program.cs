using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train();
            Station goes = new Station("Goes");

            Traveler traveler = new Traveler("Vlissingen", 1);
            Traveler traveler2 = new Traveler("Vlissingen", 2);
            Traveler traveler3 = new Traveler("Vlissingen", 2);
            Traveler traveler4 = new Traveler("Vlissingen", 2);
            Traveler traveler5 = new Traveler("Vlissingen", 2);
            Traveler traveler6 = new Traveler("Vlissingen", 2);
            Traveler traveler7 = new Traveler("Middelburg", null);

            goes.GetIn(train, traveler);
            goes.GetIn(train, traveler2);
            goes.GetIn(train, traveler3);
            goes.GetIn(train, traveler4);
            goes.GetIn(train, traveler5);
            goes.GetIn(train, traveler6);
            goes.GetIn(train, traveler7);

            Console.WriteLine(train.ToString());

            Station arnemuiden = new Station("Arnemuiden");

            train.AddWagons(arnemuiden, 1);

            Traveler traveler8 = new Traveler("Vlissingen-Souburg", 2);
            Traveler traveler9 = new Traveler("Vlissingen-Souburg", 2);

            arnemuiden.GetIn(train, traveler8);
            arnemuiden.GetIn(train, traveler9);

            Console.WriteLine(train.ToString());

            Station middelburg = new Station("Middelburg");

            train.CheckCards(middelburg);

            middelburg.GetOut(train);

            Traveler traveler10 = new Traveler("Vlissingen", 1);
            middelburg.GetIn(train, traveler10);

            Console.WriteLine(train.ToString());

            Station vlissingenSouburg = new Station("Vlissingen-Souburg");

            vlissingenSouburg.GetOut(train);

            Console.WriteLine(train.ToString());

            Station vlissingen = new Station("Vlissingen");

            vlissingen.GetOut(train);

            Console.WriteLine(train.ToString());

            Console.Read();
        }
    }
}
