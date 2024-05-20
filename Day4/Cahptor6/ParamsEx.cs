using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day4.Cahptor6
{
    internal class ParamsEx : Print
    {
        public ParamsEx() 
        {
            Write("1부터 5까지의 합은?");
            int sum = Sum(1, 2, 3, 4, 5);
            Write($"결과 : {sum}");
        }
        public int Sum(params int[] args)
        {
            int sum = 0;

            for (int i = 0; i < args.Length; i++) 
            { 
                sum += args[i];
            }

            return sum;
        }
    }
}
