using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day3.Chapter3
{
    internal class FloatDoubleEx : Print
    {
        public FloatDoubleEx() 
        {
            //소수점을 표현할수 있는 타입
            float a = 3.1415_9265_3589_7932_3846f;
            Write(a);

            //실무적으로 사용되는 소수형 타입
            double b = 3.1415_9265_3589_7932_3846;
            Write(b);

            //제일 정확한 소수점을 표현할수 있는 타입
            decimal c = 3.1415_9265_3589_7932_3846m;
            Write(c);
        }
    }
}
