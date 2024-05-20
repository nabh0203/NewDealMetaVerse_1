using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day5.Cahptor7
{
    public class Zoo
    {
        //해당 코드에서는 객체 생성이 진행되지 않아 오류가 뜨는 것
        //Animal animal;
        //animal.name =  "톰";

        //객체 생성 올바른 예
        //Animal animal = new Animal();
        //animal.name = "톰";
        //animal.sound = "야옹";
        //animal.PlaySound();

        public Zoo() 
        {
            //객체를 생성하기 위해서는 new 키워드를 사용해야한다.
            //Animal animal;
            //animal = new Animal();
            //animal.name = "톰";
            //해당코드 처럼 new() 만을 사용하여 객체를 생성할수 있다.
            //그러나 이렇게 사용하는 경우에는 다른객체를 생성할수 없기 때문에 사용하지 않는다
            //animal = new(); 


            //톰 에 대한 객체 
            Animal tom = new Animal();
            //tom.color = "빨강";
            tom.name = "톰";
            tom.sound = "야옹";
            tom.PlaySound();

            //제리 에 대한 객체
            Animal jerry = new Animal();
            jerry.name = "제리";
            jerry.sound = "찍찍";
            jerry.PlaySound();

            //객체를 통해 여러마리를 생성할수 있다.
            //3
            //for 문을 사용하여 객체 생성하기
            //for(int i = 0; i < 10; i++)
            //{
            //    Animal animal = new Animal();
            //    animal.name = "몬스터";
            //    animal.sound = "우아~";
            //    animal.PlaySound();
            //}

            jerry = tom;
            jerry.name = "미키";

            tom.PlaySound();
            jerry.PlaySound();

            Dog dog = new Dog();
            //Dog dog1 = new Dog("노렁이");
            //Dog dog2 = new Dog("노렁이" , "멍멍");
            dog.name = "누렁이";
            dog.sound = "멍멍";
            dog.PlaySound();
            //특별한 명령을 구현하기 위하여 다른 스크립트에서 작성하여 사용할수 있게
            //제작한다.
            dog.ShoutSound();


            //Orc orc = new Orc();
            //string orcSize = orc.GetSize();
            //Debug.WriteLine(orcSize);

            //Monster monster = new Monster();
            //monster.type = "불가능";

            
        }        
    }
}
