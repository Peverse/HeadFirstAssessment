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
            Traveler traveler = new Traveler("Vlissingen", 1);
            Traveler traveler2 = new Traveler("Vlissingen", 2);
            Traveler traveler3 = new Traveler("Vlissingen", 2);
            Traveler traveler4 = new Traveler("Vlissingen", 2);
            Traveler traveler5 = new Traveler("Vlissingen", 2);
            Traveler traveler6 = new Traveler("Vlissingen", 2);
            Traveler traveler7 = new Traveler("Middelburg", null);

            train.GetIn(traveler);
            train.GetIn(traveler2);
            train.GetIn(traveler3);
            train.GetIn(traveler4);
            train.GetIn(traveler5);
            train.GetIn(traveler6);
            train.GetIn(traveler7);

            train.AddWagons(1);

            Traveler traveler8 = new Traveler("Vlissingen-Souburg", 2);
            Traveler traveler9 = new Traveler("Vlissingen-Souburg", 2);
            train.GetIn(traveler8);
            train.GetIn(traveler9);


            Console.Read();
        }
    }
}
