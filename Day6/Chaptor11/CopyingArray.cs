using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day6.Chaptor11
{
    public  class CopyingArray : Print
    {
        public CopyingArray()
        {
            int[] source = new int[] {1,2,3,4,5};
            int[] target = new int[source.Length];

            CopyArray<int>(source, target);
            foreach(var element in target)
            {
                WriteSingle(element);
            }

            //이런식으로 CopyArray<T> 에서 T 부분을 원하는 타입으로 변환하여 사용할수 있다.
            string[] strSource = new string[] { "뉴딜" ,"메타버스" ,"화이팅"};
            string[] strTarget = new string[strSource.Length];
            
            CopyArray<string>(strSource, strTarget);
            foreach (var element in strTarget)
            {
                WriteSingle(element);
            }

        }

        void CopyArray<T>(T[] source,T[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];  
            }    
        }
        //만약 위에 코드를 double,string 타입으로 만들고 싶을때 똑같은 코드를 작성하는것이아닌
        //void CopyArray(int [] source, int[] target) -> void CopyArray<T>(T[] source,T[] target)
        //로 바꾸면 원하는대로 타입을 바꿔 사용할수 있다.
        void CopyArray(string [] source, string[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
    }
}
