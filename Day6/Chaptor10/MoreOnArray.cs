using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace NewDealMetaverse.Day6.Cahptor10
{
    public class MoreOnArray : Print
    {
        public MoreOnArray()
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };

            //foreach 형식
            //foreach (데이터타입 / for문안에서 사용할 변수명 /  in / 사용할 변수명)
            //데이터 타입에 var를 입력하면 배열변수로 지정한타입에 알맞게 설정해준다.
            //for문에서는 scores[i] 형대로 특정인덱스의 값에 접근이 가능하다.
            //다만 전체 for문을 순차적으로 돌때는 [for문안에서 사용할 변수명]을 사용하여
            //간단하게 코드가 구현가능하다.
            //foreach문은 인덱스(배열의 순서) 첫번쨰부터 반환을 한다.
            WriteSingle("초기 배열값 :");
            foreach (int score in scores)
            {
                WriteSingle($"{score}");
            }
            Write("");
            //Sort는 역순으로 배열을 바꾼다
            Array.Sort(scores);
            WriteSingle("Sort 이후 배열값 : ");
            //Array.ForEach<T>(T[], Action<T>) - 형식
            //foreach 와 같은 동작을 한다.
            Array.ForEach(scores, new Action<int>(Print));

            //foreach (int score in scores)
            //{
            //    WriteSingle($"{score}");
            //}
            Write("");

            //Rank
            //Rank 는 배열의 차원을 반환

            //BinarySearch 기능을 통한 인덱스 찾기
            //BinarySearch를 사용하여 원하는 값이 몇번쨰 배열에 속해있는지 알수 있다.
            //BinarySearch는 선조건이 있으며 중간부터 시작하여 인덱스를 반으로 쪼개가며
            //수를 찾는 횟수를 줄일 수 있다.
            //단점으로는 배열이 오른차 순 이고 순서대로 나열되어있어야지만 정확한 값을 도출해낸다.
            //int indexBinary =Array.BinarySearch<int>(scores, 81);
            //Write($"Binary Search : 81 is at {indexBinary}");

            //Linear 방식을 이용한 인덱스 찾기
            //int indexLinear = Array.IndexOf(scores, 81);
            //Write($"Linear Search : 81 is at {indexLinear}");

            //.TrueForAll
            //반환형 bool : Array.TrueForAll<데이터타입>(배열형, 함수형)
            Write($"{Array.TrueForAll(scores, CheckPassed)}");

            //GetLength 다차원에서의 길이 반환
            Write($"Old Length of scores : {scores.GetLength(0)}");

            //Resize 배열의 크기 조정
            Array.Resize(ref scores, 10);
            Write($"new Length of scores : {scores.Length}");

            Array.ForEach(scores, new Action<int>(Print));
            Write("");

            scores[^1] = 20;
            //Clear (배열명,시작인덱스,길이)
            Array.Clear(scores, 3, 6);
            Array.ForEach(scores, new Action<int>(Print));
            Write("");

            //Copy

            int[] sliced = new int[3];
            //int[] newArray = scores;
            //Array.Copy(1. 원본배열명 2.원본배열에서 복사를 시작할 인덱스
            //3. 복사할 배열명 4. 복사할 배열의 시작인덱스 5. 총 복사할길이)
            Array.Copy(scores, 0, sliced, 0, 3);
            Array.ForEach(sliced, new Action<int>(Print));
            Write("");

            //scores[scores.Length - i] 마지막 인덱스는 i가 1일때
            //마지막 인덱스를표시할때 위처럼 사용하지만 줄여서 ^1 를사용한다.
            //scores[^1]
            //마지막에서 두번째 인덱스
            //scores[^2]


            //중요도
            //Sort , IndexOf , TrueForAll(선택) , Clear, Copy
        }
        private bool CheckPassed(int score)
        {
            return score >= 30;
        }

        private void Print(int value)
        {
            WriteSingle($"{value}");
        }
    }
}
