using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public class Train
    {

        private int wagons;
        public ArrayList firstClass;
        public ArrayList secondClass;

        public Train()
        {
            this.firstClass = new ArrayList(3);
            this.secondClass = new ArrayList(4);
        }

        public void AddWagons(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                wagons++;
                firstClass.Capacity = firstClass.Capacity + 3;
                secondClass.Capacity = secondClass.Capacity + 4;
                this.WagonChange();
            }
        }

        

        public void GetIn(Traveler traveler)
        {
            if(traveler.GetCard() == 1)
            {
                firstClass.Add(traveler);
                Console.WriteLine("Reiziger stapt in de eerste klas");
            }

            else
            {
                if (secondClass.Count < secondClass.Capacity)
                {
                    secondClass.Add(traveler);
                    Console.WriteLine("Reiziger stapt in de tweede klas");
                }

                else
                {
                    firstClass.Add(traveler);
                    Console.WriteLine("Tweedeklas zit vol, Reiziger stapt in de eerste klas");
                }
            }
        }

        public void GetOut(Station station)
        {
            foreach (Traveler traveler in firstClass)
            {
                if(traveler.GetDestination() == station.location)
                {
                    firstClass.Remove(traveler);
                }
            }

            foreach (Traveler traveler in secondClass)
            {
                if (traveler.GetDestination() == station.location)
                {
                    secondClass.Remove(traveler);
                }
            }
        }

        public void WagonChange()
        {
            ArrayList waiting = new ArrayList();

            foreach (Traveler traveler in firstClass)
            {
                waiting.Add(traveler);
            }

            firstClass.Clear();

            foreach (Traveler traveler in secondClass)
            {
                waiting.Add(traveler);
            }

            secondClass.Clear();

            foreach (Traveler traveler in waiting)
            {
                this.GetIn(traveler);
            }
        }
    }
}
