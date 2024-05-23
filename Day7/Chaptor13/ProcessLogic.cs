using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day7.Chaptor13
{
    public delegate void Notify();
    public class ProcessLogic
    {
        public event Notify ProcessCompleted; 

        public void StartProcess()
        {
            Debug.WriteLine("이 클래스를 사용하는 특정 클래스에서 프로세스시작을 요청했습니다");

            //내부 로직이 시작했습니다.
            /*
             
             코드
             
             */

            //내부 로직이 끝났습니다.
            ProcessCompleted?.Invoke();


        }
    }
}
