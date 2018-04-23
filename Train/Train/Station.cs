using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Station
    {

        private Stack<Traveler> perron = new Stack<Traveler>();


        public void RijdBinnen(Train train)
        {
            EmptyTrain(train);
            FillTrain(train);
        }

        private void EmptyTrain(Train train)
        {
            foreach (var name in train.GetNames())
            {
                Traveler uitgestapte = train.GetOut(name);
                perron.Push(uitgestapte);
            }
        }

        private void FillTrain(Train train)
        {
            while (perron.Count != 0)
            {
                Traveler opgestapelde = perron.Pop();
                bus.GetIn(opgestapelde);
            }

        }
    }
}