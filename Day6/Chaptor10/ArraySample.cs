using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day6.Cahptor10
{
    internal class ArraySample : Print
    {
        public ArraySample()
        {
            int[] scores = new int[5];


            scores[0] = 10;
            scores[1] = 20;
            scores[2] = 30;
            scores[3] = 40;
            scores[4] = 50;

            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = (i+1) * 10 ;
            }

            for (int i = 0; i < scores.Length; i++)
            {
                WriteSingle(scores[i]);
            }

            int sum = 0;
            for(int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            Write("");
            Write($"sum = {sum}");

            int average = sum / scores.Length;
            Write($"average = {average}");
        }

    }
}
