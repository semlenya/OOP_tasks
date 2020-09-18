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

        public static Rational Sum(Rational d2)
        {
            HMACRIPEMD160 ;
            Rational d3 = new Rational();
            d3.chis = d1.chis * d2.znam + d2.chis * d1.znam;
            d3.znam = d1.znam * d2.znam;
            return d3;
        }

        public static Rational operator +(Rational d1, Rational d2)
        {
            return d1.Sum(d2);
        }
    }
}
