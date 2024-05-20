using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day4.Cahptor6
{
    internal class OptionalParameterEx :Print
    {
        public OptionalParameterEx()
        {
            PrintProfile("나병호", "010-8976-9568");
            PrintProfile("나병호" ,address: "서울시 관악구");
            //인수가 2개일때 따로따로 적으면 오류가 발생한다. 
            //그러나 지금은 두번째 인수를 선택적 인수로 입력을 하니 오류가 생기지 않는다.
            //이 이유로는 string phone의 값이 들어가지 않았을때는 뒤에 입력한 값을 출력한다.
            //PrintProfile("나병호");
            
        }
        //만약 인수가 선택적 인수로 지정되어있을때 뒤어 생성되는 인수도 선택적수 인수로 지정해야한다.
        //그래서 선택적 인수는 마지막 인수만 선택적 인수로지정하거나 오버 로딩을 통하여 제작해야 한다.
        public void PrintProfile( string name , string phone = "010-0000-0000", string address = "서울시")

        {
            Write($"Name : {name}, Phone : {phone} , Address : {address}");

        }
    }
}
