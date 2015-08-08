using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data
{
    public abstract class Offer : IOffer
    {
        private OfferType type;
        private IEstate estate;

        protected Offer()
        {                
        }

        protected Offer(OfferType type, IEstate estate)
        {
            this.Type = type;
            this.Estate = estate;
        }

        public OfferType Type { get; set; }

        public IEstate Estate { get; set; }

        public override string ToString()
        {
            string output = String.Format("{0}: Estate = {1}, Location = {2}, ",this.GetType().Name, Estate.Name, Estate.Location);
            return output;
        }
    }
}
