using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public class Traveler
    {
        private string destination;
        private int? card;

        public Traveler(string destination, int? card)
        {
            this.destination = destination;
            this.card = card;
        }

        public int? GetCard()
        {
            return card;
        }

        public string GetDestination()
        {
            return destination;
        }

        public void SetDestination(string destination)
        {
            this.destination = destination;
        }
    }
}
