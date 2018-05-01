using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public class Train
    {

        private int wagons = 1;
        public ArrayList firstClass;
        public ArrayList secondClass;

        public Train()
        {
            this.firstClass = new ArrayList(3);
            this.secondClass = new ArrayList(4);
        }

        public void AddWagons(Station station, int amount)
        {
            Console.WriteLine("Er zijn " + amount + " wagons aangekoppeld op station " + station.location + ".\n" +
                                "De reizigers gaan nu verzitten. \n");

            for (int i = 0; i < amount; i++)
            {
                wagons++;
                firstClass.Capacity = firstClass.Capacity + 3;
                secondClass.Capacity = secondClass.Capacity + 4;
                this.WagonChange(station);
            }
        }

        public void WagonChange(Station station)
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
                station.GetIn(this, traveler);
            }
        }

        public void CheckCards(Station nextstation)
        {
            foreach(Traveler traveler in firstClass)
            {
                if(traveler.GetCard() == null)
                {
                    traveler.SetDestination(nextstation.location);
                    Console.WriteLine("Dat wordt een boete meneer! U moet eruit bij Station " + nextstation.location + ".\n");
                }
            }

            foreach (Traveler traveler in secondClass)
            {
                if (traveler.GetCard() == null)
                {
                    traveler.SetDestination(nextstation.location);
                    Console.WriteLine("Dat wordt een boete meneer! U moet eruit bij Station " + nextstation.location + ".\n");
                }
            }
        }

        public override string ToString()
        {
            return "Deze trein heeft " + this.wagons + " wagons\n" +
                "Er zitten " + this.firstClass.Count + " reizigers in de eerste klas.\n" +
                "Er zitten " + this.secondClass.Count + " reizigers in de tweede klas.\n";
        }
    }
}
