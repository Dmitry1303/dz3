
namespace dz_3
{
    struct Complex_struct
    {
        public double Re, Im;

        public Complex_struct(double re, double im)
        {
            Re = re;
            Im = im;
        }
        public Complex_struct Plus(Complex_struct x)
        {
            Complex_struct y;
            y.Im = Im + x.Im;
            y.Re = Re + x.Re;
            return y;
        }
        public Complex_struct Minus(Complex_struct x)
        {
            Complex_struct y;
            y.Im = Im - x.Im;
            y.Re = Re - x.Re;
            return y;
        }
        public Complex_struct Multi(Complex_struct x)
        {
            Complex_struct y;
            y.Im = Re * x.Im + Im * x.Re;
            y.Re = Re*x.Re- Im*x.Im;
            return y;
        }
        public override string ToString()
        {

            return $"{Re}+i{Im}";
        }
    }
}