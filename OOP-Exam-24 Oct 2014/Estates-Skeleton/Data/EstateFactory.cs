using Estates.Engine;
using Estates.Interfaces;
using System;
using System.Runtime.CompilerServices;

namespace Estates.Data
{
    public class EstateFactory
    {
        public static IEstateEngine CreateEstateEngine()
        {
            return new EstateEngine();
        }

        public static IEstate CreateEstate(EstateType type)
        {
            switch (type)
            {
                case EstateType.Apartment: 
                    return new Apartment();
                case EstateType.Office:
                    return new Office();
                case EstateType.House:
                    return new House();
                case EstateType.Garage:
                    return new Garage();
                default:
                    throw new ArgumentException("Type does not exist");
            }
        }

        public static IOffer CreateOffer(OfferType type)
        {
            switch (type)
            {
                case OfferType.Sale:
                    return new Sale();
                case OfferType.Rent:
                    return new Rent();
                default:
                    throw new ArgumentException("That type does not exist.");
            }
        }
    }
}
