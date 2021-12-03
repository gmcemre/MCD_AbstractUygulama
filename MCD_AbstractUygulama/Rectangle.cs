using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractUygulama
{
    public class Rectangle:Shape 
    {
        private float _height;
        private  float  _width;

        public float Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public float Widht
        {
            get
            {
                return _width ;
            }
            set
            {
                _width  = value;
            }
        }

        

        public override void CalculateArea()
        {
            this.Area = _height * _width;
            Console.WriteLine("Rectangle Area= " + this.Area );
        }

        public override void CalculatePrimeter()
        {
            this.Perimeter = (_height + _width) * 2;
            Console.WriteLine("Rectangle Primeter= " + this.Perimeter );
        }   

        public  Rectangle(float height , float width)
        {
            _height = height;
            _width = width;

            
        }
    }
}
