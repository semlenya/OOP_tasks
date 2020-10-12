using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Rational_Calculator
{
    class Rational
    {
        public int chis;
        public int znam;

        public Rational()
        {

        }
        public Rational(int ch, int zn)
        {
            chis = ch;
            znam = zn;
        }

        public static Rational Sum(Rational d1, Rational d2)
        {
            Rational d3 = new Rational();
            d3.chis = d1.chis * d2.znam + d2.chis * d1.znam;
            d3.znam = d1.znam * d2.znam;
            Reducation(d3);
            return d3;
        }

        public static Rational Raz(Rational d1, Rational d2)
        {
            Rational d3 = new Rational();
            d3.chis = d1.chis * d2.znam - d2.chis * d1.znam;
            d3.znam = d1.znam * d2.znam;
            Reducation(d3);
            return d3;
        }
        public static Rational Umn(Rational d1, Rational d2)
        {
            Rational d3 = new Rational();
            d3.chis = d1.chis * d2.chis;
            d3.znam = d1.znam * d2.znam;
            Reducation(d3);
            return d3;
        }
        public static Rational Del(Rational d1, Rational d2)
        {
            Rational d3 = new Rational();
            d3.chis = d1.chis * d2.znam;
            d3.znam = d1.znam * d2.chis;
            Reducation(d3);
            return d3;
        }
        public static Rational operator +(Rational d1, Rational d2)
        {
            return Sum(d1, d2);
        }
        public static Rational operator -(Rational d1, Rational d2)
        {
            return Raz(d1, d2);
        }
        public static Rational operator *(Rational d1, Rational d2)
        {
            return Umn(d1, d2);
        }
        public static Rational operator /(Rational d1, Rational d2)
        {
            return Del(d1, d2);
        }

        static void Reducation(Rational dr3)
        {
            if (dr3.chis == dr3.znam)
            {
                dr3.chis = 1;
                dr3.znam = 1;
            }
            else
            {
                int c = dr3.chis, z = dr3.znam;
                while (c != 0 && z != 0)
                {
                    if (c > z)
                        c %= z;
                    else
                        z %= c;
                }
                dr3.chis /= c + z;
                dr3.znam /= c + z;
            }
        }

    }
}
