using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_3
{
    class Drob
    {
        private int _Num; // числитель
        private int _Den; // знаменатель
        public Drob()
        {
            //что-то дефаултное
        }


        public double Nms
        {
            get
            {
                return (double)_Num / (double)_Den;
            }
        }
        public int Num
        {
            get
            {
                return _Num;
            }
            set
            {
                _Num = value;
            }
        }
        public int Den
        {
            get
            {
                return _Den;
            }
            set
            {
                if (value==0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }
                _Den = value;
            }
        }
        int nod(int f, int l)
        {
            return (f%l)!=0 ? nod(l, f % l) : l;
            // рекурсия
        }
        public string Nod
        {
            get
            {
  
                int nodo = nod(_Num, _Den);
                Drob socr = new Drob(_Num / nodo, _Den / nodo);
                return $"{socr.Num}/{socr.Den}";
            }
        }
        public string Abs
        {
            get
            {
                return $"{_Num * _Num} / {_Den * _Den}";
            }
        }

        public Drob(int Num, int Den)
        {
            _Num = Num;

            #region trycatch
            //try
            //{
            //    if (Den == 0)
            //    {
            //        throw new ArgumentException("Знаменатель не может быть равен 0");
            //    }
            //}
            //catch
            //{
            //    Helps.Print("Знаменатель не может быть равен 0");
            //    Helps.Pause();
            //    Environment.Exit(0);
            //}
            #endregion

            if (Den == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }
            _Den = Den;
        }

        public override string ToString()
        {
            return $"{_Num}/{_Den}";
        }


        public static Drob operator +(Drob a, Drob b)
        {
            return new Drob(a._Num * b._Den + b._Num * a._Den, a._Den * b._Den);
        }

        public static Drob operator -(Drob a, Drob b)
        {
            return new Drob(a._Num * b._Den - b._Num * a._Den, a._Den * b._Den);
        }

        public static Drob operator *(Drob a, Drob b)
        {
            return new Drob(a._Num * b._Num, a._Den * b._Den);
        }

        public static Drob operator /(Drob a, Drob b)
        {
            return new Drob(a._Num * b._Den, a._Den * b._Num);
        }


    }
}