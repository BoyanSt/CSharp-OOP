using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data
{
    public class Apartment : Estate, IApartment
    {
        private int rooms;
        private bool hasElevator;

        public Apartment()
        {              
        }

        public Apartment(string name, double area, string location, bool isFurnished, int rooms,
            bool hasElevator) : base(name, EstateType.Apartment,  area, location, isFurnished)
        {
            this.Rooms = rooms;
            this.HasElevator = hasElevator;
        }


        public int Rooms
        {
            get
            {
                return this.rooms;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("rooms numer cannot be negativ number","rooms");
                }
                this.rooms = value;
            }
        }

        public bool HasElevator { get; set; }

        public override string ToString()
        {        
            string elevator = null;

            if (this.HasElevator)
            {
                elevator = "Yes";
            }
            else
            {
                elevator = "No";
            }
            string output = base.ToString() + string.Format("Rooms: {0}, Elevator: {1}", this.Rooms, elevator);
            return output;
        }
    }
}
