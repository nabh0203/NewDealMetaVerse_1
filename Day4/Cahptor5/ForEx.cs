using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day4.Cahptor5
{
    internal class ForEx : Print
    {
        public ForEx()
        {
            Write($"정수를 0부터 9까지 출력하겠습니다.");
            //int i = 0; - 변수 선언
            //i < 10; - 조건식
            //i++ - 증감식
            //for (int i = 0; i < 10; i+=2)
            for (int i = 0; i < 10; i++)
            {
                //if(i % 2 == 0)
                Write(i);

            }

            //아래 코드형식처럼 작성이 가능하다.
            //int j = 0;
            //for (; j < 10;) 
            //{
            //    j++
            //}

        }
    }
}
