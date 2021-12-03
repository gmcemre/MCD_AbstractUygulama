using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractUygulama
{
    public class Circle : Shape 
    {
        private float  _radius;

        public float   Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }


        public override void CalculateArea()
        {
            this.Area = 3 * _radius * _radius;
            Console.WriteLine("Circle Area= " + this.Area);
        }

        public override void CalculatePrimeter()
        {
            this.Perimeter = 2 * 3  * _radius;
            Console.WriteLine("Circle Primeter= " + this.Perimeter );
        }

        public Circle(float radius)
        {
            _radius = radius;
            
        }
    }
}
