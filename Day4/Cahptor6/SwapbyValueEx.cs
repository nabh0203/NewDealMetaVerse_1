using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day4.Cahptor6
{
    internal class SwapbyValueEx :Print
    {
        public SwapbyValueEx() 
        {
            int x = 3, y = 4;
            Swap(x,y);
            
            Write($"x = {x}, y = {y}");
        }


        public void Swap(int a, int b) 
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
