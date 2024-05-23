using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day4.Cahptor5
{
    internal class DoWhileEx : Print
    {
        public DoWhileEx()
        {
            int i = 1;

            //A do while
            do
            {
                Write($"A가 총을 {i}번 쐈습니다.");
                Write($"B가 총을 맞았습니다.");
                i++;
            }
            while (i <= 10);


            //B do while
            do
            {
                Write($"B가 총을 {i}번 피했습니다.");
            }
            while (i <= 10);


        }
    }
}
