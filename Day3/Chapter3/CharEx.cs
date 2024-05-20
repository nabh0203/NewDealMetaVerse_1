using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day3.Chapter3
{
    internal class CharEx : Print
    {
        public CharEx()
        {
            char a = '안';
            char b = '녕';
            char c = '하';
            char d = '세';
            char e = '요';

            //"" 을 붙이는 이유는 string 이라는 걸 인식하기 위함이다.
            string s = "" + a + b + c + d + e;
            Write(s);
        }
    }
}
