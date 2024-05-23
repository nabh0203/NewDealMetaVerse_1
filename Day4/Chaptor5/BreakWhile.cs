using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day4.Cahptor5
{
    internal class BreakWhile : Print
    {
        public BreakWhile() 
        {
            int monsterHP = 100;
            int myDamage = 10;
            int count = 1;

            while (true) 
            {
                monsterHP -= myDamage;
                Write($"몬스터를 {count}번 공격했습니다.");
                count++;

                if ( monsterHP <= 0)
                {
                    Write("몬스터가 죽었습니다.");
                    break;
                } 
            }

        }
    }
}
