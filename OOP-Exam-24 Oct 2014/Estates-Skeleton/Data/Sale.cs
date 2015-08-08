using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data
{

    public class Sale : Offer, ISaleOffer
    {
        private decimal price;

        public Sale()
        {  
            this.Type = OfferType.Sale;
        }

        public Sale(IEstate estate, decimal price) : base(OfferType.Sale, estate)
        {
            this.Price = price;
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Price cannot be negativ.");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return base.ToString()+string.Format("Price = {0}",this.Price);
        }
    }
}
