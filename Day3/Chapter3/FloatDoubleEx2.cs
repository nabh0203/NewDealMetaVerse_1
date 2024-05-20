using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day3.Chapter3
{
    internal class FloatDoubleEx2 : Print
    {
        public FloatDoubleEx2()
        {
            float floatSum = 1f;
            double doubleSum = 1d;

            //0.0001을 10000번 더함
            for (int i = 0; i < 10000; i++)
            {
                floatSum += 0.0001f;
                doubleSum += 0.0001d;
            }
            //예상 결과는 2.0
            Write($"Float 결과 {floatSum}");
            Write($"Double 결과 {doubleSum}");
        }
    }
}
