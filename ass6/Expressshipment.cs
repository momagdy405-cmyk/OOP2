using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass6
{
    internal class Expressshipment : Shipman
    {
        private decimal extrafee;
        public decimal Extrafee
        {
            get
            {
                return extrafee >= 0 ? del * 0.5m : 0;


            }
        }
        public Expressshipment(decimal extrafee) : base()
        {
            this.extrafee = extrafee;
        }

        public override decimal Estimate
        {
            get
            {
                return del + (Weight * 5) + Extrafee;
            }
        }
    }
}
