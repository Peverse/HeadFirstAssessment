using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public class Traveler
    {
        string destination;
        string card;

        public Traveler(string destination, string card)
        {
            this.destination = destination;
            this.card = card;
        }

        public string GetCard()
        {
            return this.card;
        }
    }
}
