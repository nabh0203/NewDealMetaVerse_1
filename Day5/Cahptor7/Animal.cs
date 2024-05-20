using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day5.Cahptor7
{
    //internal class  Animal
    //접근한정자 class 클래스 명
    //접근한정자는 생략 가능하나 생략할 경우 Private 로 적용된다
    //접근한정자 종류 : public / private / protected /internal
    public class Animal
    {
        
        //해당 변수가 작성된 스크립트와 해당 스크립트의 클래스를 받는 스크립트에서만
        //사용가능하게 해주는 접근제한자이다.
        //protected string type;

        //동물에 필수로 필요한 변수
        //C# 에서는 전역변수를 필드(Field) 라고 부른다
        //전역변수라는 표현을 쓴다.
        //전역변수의 선언 방식은 ({접근한정자} {변수타입} {변수이름} {;}) 이런식으로 작성한다.
        //public string namespace = "초기값";

        //대부분의 전역변수에 _ (언더바) 를 앞에 붙여 전역변수를 구분한다.
        public string _name;
        public string _sound;

        public string name;
        public string sound;



        //private 로 대부분 변수를 생성한다.
        //private string color;



        //생성자 : 모든 클래스에서 최초 객체 생성시 한번 호출된다.
        public Animal()
        {
            //color = "빨강";
        }

        // PlaySound() 함수를 dog 스크립트에서 다르게 사용하기 위해선
        //상속해주는 부모 클래스의 함수 void 앞에 virtual,abstract 를 붙여야한다.
        public virtual void PlaySound()
        {
            //color = "노랑";
            //유니티 내에서 디벙깅 시 사용하는 코드
            //Debug.Log();

            //C# 내에서 디버깅 시 사용되는 코드
            Debug.WriteLine(name + " " + sound);

            //아래의 방식은 나온지 얼마 안된방식이다.
            //Debug.WriteLine($"{name} : {sound}");
        }
    }
}
