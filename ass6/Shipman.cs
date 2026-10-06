using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass6
{
    internal class Shipman
    {
        private string trackingcode;
        private string description;
        private int weight;
        private decimal deliveryfee;
        public string Trackingcode
        {
            get
            {
                return trackingcode;
            }

        }

        public string descripe
        {
            get
            {
                return description;
            }
            set
            {
                description = string.IsNullOrWhiteSpace(value) ? description : value;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value > 0 ? value : weight;
            }
        }
        public decimal del
        {
            get
            {
                return deliveryfee;
            }
            private set
            {
                deliveryfee = value > 0 ? value : deliveryfee;
            }
        }


        public virtual decimal Estimate
        {
            get { return deliveryfee + (weight * 5); }
        }
        public Delivaryaddress destination { get; set; }
        public Shipman()
        {
            trackingcode = "invalid";
            description = "unknown";
            weight = 1;
            deliveryfee = 50;
        }
        public Shipman(string trackingcode)
        {
            this.trackingcode = string.IsNullOrWhiteSpace(trackingcode) ? "invalid" : trackingcode;
            description = "unknown";
            weight = 1;
            deliveryfee = 50;
        }
        public Shipman(string trackingcode, string description, int weight, int delivery, Delivaryaddress destination)
        {
            this.trackingcode = trackingcode;
            this.description = description;
            this.weight = weight;
            this.deliveryfee = delivery;
            this.destination = destination;
        }
        public Shipman(string trackingcode, string description, int weight)
        {
            this.trackingcode = trackingcode;
            this.description = description;
            this.weight = weight;
        }
        public void updatedeliveryfee(decimal newfee)
        {
            if (newfee > 0)
            {
                deliveryfee += newfee;
            }
        }
        public void printshipman()
        {
            Console.WriteLine($"the tracking code is:{trackingcode},the description of our order is:{description},the weight of the delivery is:{weight}");
        }
    }
   
    }
