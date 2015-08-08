using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data
{
    public class Rent: Offer, IRentOffer
    {
        private decimal pricePerMonth;

        public Rent()
        {
            this.Type = OfferType.Rent;
        }

        public Rent(IEstate estate, decimal pricePerMonth) : base(OfferType.Rent, estate)
        {
            this.PricePerMonth = pricePerMonth;
        }

        public decimal PricePerMonth
        {
            get
            {
                return this.pricePerMonth;
            }
            set
            {
                if (value<0)
                {
                    throw new Exception("Rent price cannot be negativ.");
                }
                this.pricePerMonth = value;
            }
        }

        public override string ToString()
        {
            return base.ToString()+ String.Format("Price = {0}",this.PricePerMonth);
        }
    }
}
