using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public class Station
    {
        public string location;

        public Station(string location)
        {
            this.location = location;
        }

        public void GetIn(Train train, Traveler traveler)
        {
            if (traveler.GetCard() == 1)
            {
                train.firstClass.Add(traveler);
                Console.WriteLine("Reiziger stapt in de eerste klas");
            }

            else
            {
                if (train.secondClass.Count < train.secondClass.Capacity)
                {
                    train.secondClass.Add(traveler);
                    Console.WriteLine("Reiziger stapt in de tweede klas");
                }

                else
                {
                    train.firstClass.Add(traveler);
                    Console.WriteLine("Tweedeklas zit vol, Reiziger stapt in de eerste klas");
                }
            }
        }

        public void GetOut(Train train)
        {
            ArrayList gettingOut = new ArrayList();

            foreach(Traveler traveler in train.firstClass)
            {
                gettingOut.Add(traveler);
            }

            foreach (Traveler traveler in train.secondClass)
            {
                gettingOut.Add(traveler);
            }

            foreach(Traveler traveler in gettingOut)
            {
                if (traveler.GetDestination() == this.location)
                {
                    train.firstClass.Remove(traveler);
                    train.secondClass.Remove(traveler);
                    Console.WriteLine("Er stapt iemand uit op Station " + this.location);
                }
            }
        }

    }
}