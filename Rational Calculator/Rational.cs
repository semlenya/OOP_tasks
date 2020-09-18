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
        public Rational( int ch, int zn)
        {
            chis = ch;
            znam = zn;
        }

        public static Rational Sum(Rational d1, Rational d2)
        {
            Rational d3 = new Rational();
            d3.chis = d1.chis * d2.znam + d2.chis * d1.znam;
            d3.znam = d1.znam * d2.znam;
            if (d3.chis == d3.znam)
            {
                d3.chis = 1;
                d3.znam = 1;
            }
            return d3;
        }

        public static Rational Raz(Rational d1, Rational d2)
        {
            Rational d3 = new Rational();
            d3.chis = d1.chis * d2.znam - d2.chis * d1.znam;
            d3.znam = d1.znam * d2.znam;
            if (d3.chis == d3.znam)
            {
                d3.chis = 1;
                d3.znam = 1;
            }
            return d3;
        }
        public static Rational Umn(Rational d1, Rational d2)
        {
            Rational d3 = new Rational();
            d3.chis = d1.chis * d2.chis;
            d3.znam = d1.znam * d2.znam;
            if (d3.chis == d3.znam)
            {
                d3.chis = 1;
                d3.znam = 1;
            }
            return d3;
        }
        public static Rational Del(Rational d1, Rational d2)
        {
            Rational d3 = new Rational();
            d3.chis = d1.chis * d2.znam;
            d3.znam = d1.znam * d2.chis;
            if (d3.chis == d3.znam)
            {
                d3.chis = 1;
                d3.znam = 1;
            }
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
    }
}
