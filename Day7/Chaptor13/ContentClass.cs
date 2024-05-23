using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day7.Chaptor13
{
    //2 작업자 : main 함수
    public class ContentClass : Print
    {
        public  ContentClass() 
        { 
            ModuleClass mc= new ModuleClass(TouchScreen);
            mc.StartCamera();
        }

        public string TouchScreen(int x, int y)
        {
            //터치 이벤트에 대한 2작업자의 코드
            string result = $"({x},{y}) 좌표를 터치했습니다.";
            //Debug.WriteLine(result);
            return result ;
        }


    }
}
