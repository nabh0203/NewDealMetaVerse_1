using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day5.Cahptor7
{
    public class Dog : Animal
    {
        string _example;
        public Dog() { }

        //소멸자(종료자)
        //객체가 가비지컬렉터에 의해서 사라질때 호출됨
        //만약 객체가 사라지면 아래의 소멸자로 돌아오게 된다.
        //대부분 사용하지는 않는다.
        ~Dog() { name = null; }  
          
        //생성자도 오버로딩이 가능하다.
        public Dog(string name) 
        { 
            //생성자를 호출하면서 생성자 내에 있는 값을 받아올때 this 로 구별하여 사용한다.
            //this 도 있지만 base도 있다.
            this.name = name;
            this._example = name;
            _example = "예시";
            //this._name = name;
        }

        public Dog(string name,string sound) { }



        public void ShoutSound()
        {
            Debug.WriteLine($"{name} : 으르렁 왈왈");

        }
        //상속받은 부모 클래스의 함수를 바꿔서 사용하려면 상속을 받는 자식 클래스에서
        //바꿀 함수 void 앞에 override 를 붙여야한다.
        //override : 덮어 씌운다.
        public override void PlaySound()
        {
            Debug.WriteLine($"{name} : {sound}~{sound}");
        }
    }
}
