using NewDealMetaverse.Day5.Cahptor7;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day7.Chaptor12
{
    //Try ~ Catch 예문
    //오류가 생겼을시 경고창 및 오류창을 출력해주는 함수
    public class TryCatch : Print
    {
        public TryCatch()
        {
            //Try~catch 를 사용하여 오류를 확인하고 수정할수 있다.
            try
            {
                //try 영역 중괄호 안에서 문제가 발생을 하면 현재 중괄호영역을 강제로 탈출하고
                //아래에 있는 catch의 중괄호 안의 내용을 수행합니다.

                Orc orc = new Orc();
                orc.Damaged(10);

                Print();

            }
            //catch는 무조건 (Exception 변수명)과 엮어서 사용해야 한다.
            catch (Exception e)
            {
                //문제가 발생했을 때 여기로 들어옵니다.
                //문제 발생시 출력할 코드를 입력한다.
                Debug.WriteLine($"에러 발생 : {e.Message}");
            }


            Debug.WriteLine("여기까지 오나요?");
        }

        public void Print()
        {
            int[] arr = { 1, 2, 3 };

            for (int i = 0; i < 5; i++)
            {
                //Write(arr[i]);
                Debug.WriteLine(arr[i]);
            }

        }
    }
}
