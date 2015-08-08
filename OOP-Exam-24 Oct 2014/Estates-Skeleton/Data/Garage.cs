using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data
{
    public class Garage:Estate,IGarage
    {
        private int width;
        private int height;

        public Garage()
        {               
        }

        public Garage(string name, double area, string location, bool isFurnished, int width, int height) : base(name, EstateType.Garage, area, location, isFurnished)
        {
            this.Height = height;
            this.Width = width;
        }

        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Width cannot be negativ.");
                }
                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Height cannot be negativ.");
                }
                this.height = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("Width: {0}, Height: {1}",this.Width,this.Height);
        }
    }
}
