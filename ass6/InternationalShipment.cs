using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass6
{
    internal class InternationalShipment: Shipman
    {
        private string destinationCountry;
        private decimal customsfee;
        public string DestinationCountry
        {
            get { 
                if(string.IsNullOrEmpty(destinationCountry)||string.IsNullOrWhiteSpace(destinationCountry))
                {
                    return "Unknown";
                }
                return destinationCountry;
            }
        }
        public decimal Customsfee
        {
            get { return customsfee>=0 ? customsfee : 0; }
        }
        public override decimal Estimate
        {
            get { return del + (Weight * 5) + Customsfee; }
        }
        public InternationalShipment(string destinationCountry, decimal customsfee) : base()
        {
            this.destinationCountry = destinationCountry;
            this.customsfee=customsfee;
        }
    }
    
}
