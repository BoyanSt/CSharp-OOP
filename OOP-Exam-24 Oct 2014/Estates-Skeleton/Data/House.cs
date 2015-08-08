using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data
{
    public class House:Estate,IHouse
    {
        private int floors;

        public House()
        {          
        }

        public House(string name, double area, string location, bool isFurnished, int floors) : base(name, EstateType.House, area, location, isFurnished)
        {
            this.Floors = floors;
        }

        public int Floors
        {
            get
            {
                return this.floors;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Numbers of floors cannot be negativ.");
                }
                this.floors = value;
            }
        }

        public override string ToString()
        {
            return base.ToString()+string.Format("Floors: {0}",this.Floors);
        }
    }
}
