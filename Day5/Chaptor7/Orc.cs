using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day5.Cahptor7
{
    public class Orc : IMonster
    {
        private int hp;
        public Orc()
        {
            hp = 100;
        }

        public int Damaged (int damage)
        {
            hp -= damage;

            return hp;
        }

        //public string Log(string log)
        //{
        //    if (hp < 100)
        //    {
        //        Console.WriteLine("데미지");
        //    }
        //    return log;
        //}
        ////private 는 작성한 스크립트 내에서만 사용가능한 접근제한자이다.
        ////Propurt 를 사용하여 외부에서 접근되게 할수 있다.
        //private string size;

        //public Orc()
        //{
        //    name = "오크";
        //    sound = "꾸어~";
        //    size = "small";
        //    type = "일반몬스터"; //protected로
        //}

        //public string GetSize()
        //{
        //    return size;
        //}

        ////public void SetSize(string size)
        ////{
        ////    this.size = size;
        ////}
    }
}
