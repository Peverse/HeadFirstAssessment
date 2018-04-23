using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public class Train
    {
        public ArrayList wagons = new ArrayList();

        public ArrayList firstClass;
        public ArrayList secondClass;

        public Train()
        {
            this.firstClass = new ArrayList(this.GetFirstClassSeats(wagons));
            this.secondClass = new ArrayList(this.GetSecondClassSeats(wagons));
        }

        public int GetFirstClassSeats(ArrayList wagons)
        {
            return wagons.Count * 3;
        }

        public int GetSecondClassSeats(ArrayList wagons)
        {
            return wagons.Count * 4;
        }

        public void GetIn(Traveler traveler)
        {
            if(traveler.GetCard() == "firstclass")
            {
                firstClass.Add(traveler);
            }

            else
            {
                if (secondClass.Count == this.GetSecondClassSeats(wagons))
                {
                    firstClass.Add(traveler);
                }

                else
                    secondClass.Add(traveler);

            }
            Console.WriteLine(firstClass);
            Console.WriteLine(secondClass);
        }
    }
}
