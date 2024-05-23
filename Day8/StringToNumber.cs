using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day8
{
    public class StringToNumber
    {
        public StringToNumber() 
        {
            string strNum = "3";
            //string strNum = "3;;";
            string strFlaot = "3.14";
            string strDouble = "3.14";

            //문자열은 숫자형으로 바꾸는 방법
            //1.Convert 클래스
            //2.변수타입.Parse()
            //3.변수타입.TryParse()

            //1번방식
            //int num1 = Convert.ToInt32(strNum); //함수명 뒤에 붙는 숫자는 비트를 의미 32 / 8 = 4 즉 4비트
            //Debug.WriteLine($"num1 은 {num1}");

            ////2번방식
            //int num2 = int.Parse(strNum);
            //Debug.WriteLine($"num2 은 {num2}");

            ////3번방식
            //int.TryParse(strNum, out int num3); //TryParse문 안에서 변수선언까지 같이 한방법
            //Debug.WriteLine($"num3 은 {num3}");
            //int num4;
            //int.TryParse(strNum, out num4); //미리 선언을 했을떄는 out 뒤에 int를 붙이지 않는다.



            //3번방식의 실제 사용 요령
            if(int.TryParse(strNum, out int num3))
            {
                Debug.WriteLine($"num3 은 {num3}");
            }
            else 
            {
                Debug.WriteLine("숫자를 정확히 입력해 주세요");
            }

            //소수점을 스트링으로 변환하는 예시.
            //Convert.T 
            double double1 = Convert.ToDouble(strDouble);
            double double2 = double.Parse(strDouble);
            //double 도 마찬가지로 if문 안에서 사용한다.
            double.TryParse(strDouble, out double double3);

            Debug.WriteLine($"double1은 {double1}");
            Debug.WriteLine($"double2은 {double2}");
            Debug.WriteLine($"double3은 {double3}");



        }
    }
}
