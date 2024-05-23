using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day8
{

    /// <summary>
    /// 각종 stirng 을 통한 문자열을 표현하는 방법
    /// </summary>
    public class Variable
    {
        //필드 영역(전역변수)

        public Variable()
        {
            //지역변수 영역

            //Text라는 놈은 입력을 받든 최종적으로 출력을 하던 무조건 문자열형태다.
            int num = 3;

            /*1. 기본적 호출 방식*/
            Debug.WriteLine($"{num}");
            //string 을 사용한 1번째 호출 방식
            string strNum = num.ToString(); //가장 많이 쓰는 문자열로 변경하는 방법

            float numFlaot = 3.141592f;
            int sum = 3 + 4;
            //123456 문자열이 만들어짐
            string strSum = "123" + "456";


            /*2. 한개의 변수를 문자로 변환하는 방법*/

            //문자열을 사용한 2번째 호출 방식
            float floatingVariable = 0.83094f;
            //ToString 내의 F3은 소수점 3자리까지 출력한다.
            Debug.WriteLine(floatingVariable.ToString("F3"));
            //Debug.WriteLine(this.ToString());

            //긴 문자열을 조합할때 사용
            //string.Format();

            /*3. 여러개의 변수를 통한 문자열 생성방식*/

            //문자열을 사용한 3번째 호출 방식
            //num은 3입니다. floatingVariabledms 0.83 입니다.
            //"" 안에서 바뀔수 있는 값은 {} 안에 넣는다.
            //"" 문장뒤에 들어가는 인수 즉 파라미터는 순서대로 작정한{} 안에 들어간다.
            // {1:F2} 처럼 : 를 입력하고 F2 를 작성하면 소수점 두자리까지만 나오게 된다.
            string str = string.Format("num은 {0}입니다. floatingVariable은 {1:F2}입니다.{2}", num, floatingVariable, 5);
            Debug.WriteLine(str);
            // 아래 방식 처럼 사용도 가능하다. 그러나 호환이 안되는 경우도 있으니 참고
            Debug.WriteLine("num은 {0}입니다. floatingVariable은 {1:F2}입니다.{2}", num, floatingVariable, 5);

            /*4. 문자열을 사용한 4번째 호출 방식*/

            string strDollar = $"num은 {num}이고, floatingVariable은 {floatingVariable} 하고 다릅니다.";
            Debug.WriteLine(strDollar);

            /*5. 멀티라인방법*/
            //string mutilineString = """

            //    한글 입력



            //    """

            //최신 기술이 들어간 멀티라인 방법
            string mutilineString = @$"안녕하세요
뉴딜메타버스 교육중입니다.
멀티라인 이렇게 사용합니다.
num은 {num}이고
floatingVariable은 {floatingVariable} 입니다.
";

            //string, Format, $, 원천적인 + 하기 방식


            /*6.가장 기본적인 문자열 생성 방법*/

            //num은 3이고 , numFloat = 3.14 입니다.
            strSum = "num은" + "3이고" + "numFloat = " + "3.14" + "입니다.";
            //strSum = num은 3이고 numFloat = 3.14 입니다.;
            strSum = "num은" + num.ToString() + "이고, " + "numFloat = " + numFlaot.ToString("F2") + "입니다.";

            string multilineOriginal = "안녕하세요.\n" +
                                       "나병호입니다.\n" +
                                       "뉴딜 메타버스\n" +
                                       "화이팅 입니다.\n" +
                                       "num은 {num}입니다.\n" +
                                       $"floatingVariable은 {floatingVariable:F2} 입니다.\n"; 
            Debug.WriteLine(multilineOriginal);



        }

        public void FunctionA()
        {
            //지역변수 영역
        }
    }
}
