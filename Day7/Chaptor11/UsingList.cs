using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day7.Chaptor11
{
    //일반화 컬렉션 List<T>
    public class UsingList : Print  
    {
        //전역 변수
        List<int> intList = new List<int>();
        public UsingList()
        {
            ////기본적인 캐스팅 방식
            ////int data =(int) a[0];
            //int data = a[0];
            
            //Resize 말고 배열갯수 늘리는 법
            List<int> intList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                intList.Add((i + 1) * 10);
            }
            

            //foreach / 받을 데이터 타입 / element in / 변수명
            //foreach (int element in intList)
            //{
            //    WriteSingle($"{element}");
            //}
            //Write("");
            
            //배열은 데이터의 개수를 가져올때 Length 프로퍼티를 사용하지만
            //List 같은 컬렉션들은 Count라는 프로퍼티를 사용한다.
            for(int i = 0; i < intList.Count; i++)
            {
                WriteSingle($"[{i}] :");
                Write(intList[i]);
            }
            Write("");

            //특정인덱스의 값을 지울떄 사용하는 함수 RemoveAt
            intList.RemoveAt(3);
            Write("RemoveAt(3)을 수행하였습니다.");
            for (int i = 0; i < intList.Count; i++)
            {
                WriteSingle($"[{i}] :");
                Write(intList[i]);
            }
            Write("");

            //Remove는 특정값을지우는 함수이다.
            //제일 앞 순서에 있는 값을 지워준다.
            //intList.Add(80);
            //intList.Remove(80);
            //intList.RemoveRange(2, 3);
            intList.Remove(20);
            Write("Remove(20)을 수행하였습니다.");
            for (int i = 0; i < intList.Count; i++)
            {
                WriteSingle($"[{i}] :");
                Write(intList[i]);
            }
            Write("");

            //배열 중간에 원하는 인덱스에 값을 넣기 위해선 Insert 를 사용한다.
            intList.Insert(5, 5);
            Write("Insert(5, 5)을 수행하였습니다.");
            for (int i = 0; i < intList.Count; i++)
            {
                WriteSingle($"[{i}] :");
                Write(intList[i]);
            }
            Write("");

            //Clear함수는 List 배열을 초기화한다.
            intList.Clear();
            Write($"Clear 이후 intList의 데이터 갯수는? {intList.Count}입니다.");
            for (int i = 0; i < intList.Count; i++)
            {
                WriteSingle($"[{i}] :");
                Write(intList[i]);
            }
            Write("");
            
            //List에서 자주 사용하는함수 = Add , RemoveAt, Remove , Clear
        }
    }
}
