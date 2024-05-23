using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day7.Chaptor13
{
    public delegate string Callback(int x, int y);
    //1 작업자 : 카메라 모듈 함수
    public class ModuleClass
    {
        //ContentCalss 가 여기서 들어가면 코드 효율이 좋지않다.
        //ContentClass myParent;
        //public ModuleClass(ContentClass parent) 
        private Callback? callback;
        public ModuleClass(Callback callback) 
        {
            //myParent = parent;
            this.callback = callback;
        }

        public void StartCamera()
        {
            Debug.WriteLine("콘텐츠에서 카메라를 이동했습니다.");

            /*로직 코드*/

            int i = 0;
            while(i < 30)
            {
                i++;
                Debug.WriteLine($"현재 {i} 프레임입니다.");
            }

            //myParent.TouchScreen(10,20);
            MyFuntion();
        }

        public void MyFuntion()
        {
            string result = callback?.Invoke(20, 30);
            Debug.WriteLine(result);

        }
    }
}
