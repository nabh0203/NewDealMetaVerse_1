using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day4.Cahptor6
{
    internal class CalculatorEx : Print
    {
        public CalculatorEx()
        {
            int a = 5, b = 6;

            //int x, y, z;
            //int result = a + b;
            int result = Plus(a, b);
            //result = Plus(3, 4);
            Printlabel();
            Write(result);

            result = Minus(a, b); 
            Write(result);
        }

        public int Plus(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }

        public void Printlabel()
        {
            Write("계산중입니다.");
            Write("결과는 다음과 같습니다.");

            return;

            
        }

    }
}
