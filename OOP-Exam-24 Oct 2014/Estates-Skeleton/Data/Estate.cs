using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data
{

    public abstract class Estate : IEstate
    {
        private string name;
        private EstateType type;
        private double area;
        private string location;
        private bool isFurnished;

        protected Estate()
        {
        }

        protected Estate(string name, EstateType type, double area, string location, bool isFurnished)
        {
            this.Name = name;
            this.Type = type;
            this.Area = area;
            this.Location = location;
            this.IsFurnished = isFurnished;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(Name, "name cannot be empty.");
                }
                this.name = value;
            }
        }

        public EstateType Type { get; set; }
 
        public double Area
        {
            get
            {
                return this.area;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Area cannot be negativ");
                }
                this.area = value;
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(Location, "Location cannot be empty.");
                }
                this.location = value;
            }
        }

        public bool IsFurnished { get; set; }

        public override string ToString()
        {
            string furniture = null;
            string elevator = null;

            if (this.IsFurnished)
            {
                furniture = "Yes";
            }
            else
            {
                furniture = "No";
            }

            string output =
                string.Format(
                    "{0}: Name = {1}, Area = {2}, Location = {3}, Furnitured = {4}, " , this.GetType().Name , this.Name , this.Area , this.Location, furniture);
            return output;
        }
    }
}
