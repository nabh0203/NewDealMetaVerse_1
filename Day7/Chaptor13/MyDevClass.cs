using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day7.Chaptor13
{
    public class MyDevClass:Print
    {
        public MyDevClass() 
        { 
         
            ProcessLogic pl = new ProcessLogic();

            pl.ProcessCompleted += Pl_ProcessCompleted;

            pl.StartProcess();
        }

        private void Pl_ProcessCompleted()
        {
            Debug.WriteLine("프로세스가 끝나서 이벤트핸들러를 호출했습니다.");
        }
    }
}
