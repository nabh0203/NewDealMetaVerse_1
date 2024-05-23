using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day4.Cahptor5
{
    internal class ContinueEx:Print
    {
        public ContinueEx()
        {
            for (int i = 0; i < 10; i++) 
            { 
                //if(i % 2 ==1)
                if(i % 2 == 0)
                {
                    //continue를 사용하면 continue 아래의 코드를 무시하고
                    //상위 코드로 돌아간다.
                    continue;
                }
                //goto 를 사용하지 않는 이유 - 디버깅시 코드가 꼬이는경우가 발생
                //if (i == 5) 
                //{
                //    goto GOTOTEST;
                //}

                Write($"{i}는 홀수");
            }
            //
            //GOTOTEST: Write("넘어왔습니다.")
        }
    }
}
