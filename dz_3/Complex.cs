using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_3
{
    class Complex
    {
        private double _Re; // реальная часть
        private double _Im; // мнимая часть

        public Complex()
        {
            
        }

        public double Re
        {
            get
            {
                return _Re;
            }
            set
            {
                _Re = value;
            }
        }
        public double Im
        {
            get
            {
                return _Im;
            }
            set
            {
                _Im = value;
            }
        }

        public double Abs
        {
            get
            {
                return Math.Sqrt(_Re * _Re + _Im * _Im);
            }
        }

        public double Arg
        {
            get
            {
                return Math.Atan2(_Im, _Re);
            }
        }
        public Complex(double Re, double Im)
        {
            _Re = Re;
            _Im = Im;
        }
        public double GetRe()
        {
            return _Re;
        }
        public void SetRe(double value)
        {
            _Re=value;
        }

        public double GetIm()
        {
            return _Im;
        }
        public void SetIm(double value)
        {
            _Im = value;
        }

        public Complex Add(Complex z)
        {
            return new Complex(_Re + z._Re, _Im + z._Im);
        }
        public override string ToString()
        {
            return $"{_Re}+i{_Im}";
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a._Re + b._Re, a._Im + b._Im);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a._Re - b._Re, a._Im - b._Im);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a._Re * b._Re-a._Im*b._Im, a._Re * b._Im+a._Im*b._Re);
        }

        public static Complex operator /(Complex a, Complex b)
        {
            return new Complex((a._Re * b._Re + a._Im * b._Im)/(b._Re*b._Re+b._Im*b._Im),
                    (a._Im * b._Re - a._Re * b._Im) / (b._Re * b._Re + b._Im * b._Im));
        }
    }

}
