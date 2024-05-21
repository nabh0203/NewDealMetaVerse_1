using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day5.Cahptor7
{
    public class Player
    {
        public Player() 
        {
            AttackArea();
        } 

        public void AttackArea()
        {
            List<IMonster> monsters = new List<IMonster>();

            monsters.Add(new Orc());
            monsters.Add(new Orc());
            monsters.Add(new Orc());
            monsters.Add(new OrcKing());
            monsters.Add(new OrcKing());

            for (int i =0; i < monsters.Count; i++)
            {
                Attack(monsters[i]);
            }
        }
        public void Attack(IMonster monster)
        {
            int hp = monster.Damaged(10);
            Debug.WriteLine(hp);
        }

        //interface를 사용함으로써 아래처럼 매개변수가 각각다른 함수를 쓸필요 없이
        //하나의 코드로 몬스터 마다 들어가는 데미지를 조정할수 있다.
        //public void Attack(Orc monster)
        //{
        //    int hp = monster.Damaged(10);
        //    Debug.WriteLine(hp);
        //}

        //public void Attack(OrcKing monster)
        //{
        //    int hp = monster.Damaged(10);
        //    Debug.WriteLine(hp);
        //}

        //interface 의 단점으로는 코드가 완성이 되고 오류를 잡아나갈때 정의로 이동하면
        //interface에서 지정한 함수로만 이동되고 일일이 코드를 확인하며 오류를 찾아야 한다는
        //단점이 있다.
    }
}
