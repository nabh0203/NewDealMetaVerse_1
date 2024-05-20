using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day4.Cahptor6
{
    internal class OverLoadingEx :Print
    {
        public OverLoadingEx()
        {
            int plus2 = Plus(1,2);
            double plusd = Plus(1.0, 3.3);

            Write(plus2);
            Write(plusd);
            Write(Plus(1,2,3));

           
        }

        public int Plus(int a, int b)
        {
            Write("Callong int Plus(int,int)...");
            return a + b;
        }

        public double Plus (double a,double b)
        {
            Write("Callong int Plus(double,double)...");
            return a + b;
        }

        public int Plus(int a, int b, int c)
        {
            Write("Callong int Plus(int,int,int)...");
            return a + b + c;
        }

    }
}
