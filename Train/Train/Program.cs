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
            Traveler traveler = new Traveler("Goes", "firstclass");
                      
            train.GetIn(traveler);
            

            Console.Read();
        }
    }
}
