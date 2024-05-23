using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day4.Cahptor5
{
    internal class BreakFor : Print
    {
        int[] arr = new int[] { 10, 21, 35, 46, 50 };

        public BreakFor()
        {
            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    Write($"{arr[i]}");

            //    if (arr[i] > 40) break;
            //}

            //for문은 무한반복을 아래퍼럼 사용합니다.
            //for (; ; )
            //{
            //    Write("무한으로 출력");
            //}
            //break 주의사항

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    Write($"x = {x} , y = {y}");
                    if (y == 3) break;
                }
            }
        }
    }
}
