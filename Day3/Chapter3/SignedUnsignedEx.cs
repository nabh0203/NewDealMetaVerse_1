using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day3.Chapter3
{
    internal class SignedUnsignedEx : Print
    {
        public SignedUnsignedEx() 
        {
            byte a = 255;
            sbyte b = (sbyte)a;

            Write(a);
            Write(b);
        }
    }
}
