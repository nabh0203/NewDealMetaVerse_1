using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day5.Cahptor7
{
    public class OrcKing : IMonster //,Iㅖrint 이런식으로 interface 를
                                    //다중상속할 수 있다. 그러나 클래스는 다중상속이 안된다.
    {
        private int hp;

        public OrcKing()
        {
            hp = 100;
        }

        public int Damaged (int damage)
        {
            hp -= (damage / 2);

            return hp;
        }

        //public string Log(string log)
        //{
        //    if (hp <100) 
        //    { 
        //        Console.WriteLine("데미지");
        //    }
        //    return log;
        //}
    }
}
