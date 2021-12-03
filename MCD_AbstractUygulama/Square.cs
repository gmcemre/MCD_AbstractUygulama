using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractUygulama
{
    public class Square:Shape 
    {
       
        private float  _side;

        public float Side
        {
            get { return _side ; }
            set { _side  = value; }
        }


        public override void CalculateArea( )
        {
            this.Area = _side * _side;
            Console.WriteLine("Square Area= "+ this .Area );
        }

        public override void CalculatePrimeter()
        {
            this.Perimeter = 4 * _side;
            Console.WriteLine("Square Primeter= " + this.Perimeter );
        }

        public Square(float side)
        {
            _side = side;
            var random = new Random();
        }

        
    }
}
