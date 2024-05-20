using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day4.Cahptor6
{
    internal class SwapByReferenceEx : Print
    {
        public SwapByReferenceEx() 
        {
            int x = 3, y = 4;
            Swap(ref x, ref y);

            Write($"x = {x}, y = {y}");
        }

        //ref 는 Reference 의 약자
        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
