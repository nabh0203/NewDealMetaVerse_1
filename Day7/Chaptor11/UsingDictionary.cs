using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day7.Chaptor11
{
    //일반화 컬렉션 Dictionary
    public class UsingDictionary : Print
    {
        public UsingDictionary() 
        {
            //Dictionary<키값,데이터값> 변수명 = new Dictionary<키값,데이터값>();
            Dictionary<int,string> dic = new Dictionary<int,string>();

            //Dictionary 에서는 [] 안의 값이 인덱스가 아니라 key값의 개념
            dic[-1] = "1 입니다.";
            dic[2] = "2 입니다.";

            Write(dic[-1]);

            foreach (var item in dic)
            {
                //WriteSingle(item);
                WriteSingle($"Key : {item.Key} / ");
                Write($"Value : {item.Value}");

                //특정 키값을 출력하기 위해선 아래처럼 활용한다.
                //if (item.Key == 2) Write
            }
            Write("-----------------------------------------------------");

            Dictionary<string,string> dicStrKey = new Dictionary<string, string>();

            dicStrKey["하나"] = "One";
            dicStrKey["둘"] = "Two";
            dicStrKey["셋"] = "Three";

            foreach (var item in dicStrKey)
            {
                WriteSingle($"Key : {item.Key} / Value : {item.Value}");
                Write(dicStrKey[item.Key]);
                
            }






            //dic은 일반적인 for문 형태로 사용불가
            //for(int i = 0; i < dic.Count; i++)
            //{
            //    Write(dic[i]);  
            //}
        }
    }
}
