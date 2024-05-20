using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day4.Cahptor5
{
    internal class WhileEx : Print
    {
        public WhileEx()
        {
            int i = 10;

            while (i > 0)
            {
                Write($"i: {i}");
                //Write($"i: {i--}"); - 잘못된 코드 형식
                //보통은 연산자를 아래로 빼서 사용한다.
                i--;
            }
        }
    }
}
