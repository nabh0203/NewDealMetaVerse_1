using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day5.Cahptor7
{
    public interface IMonster
    {
        //interface 를 쓰는 결정적 이유
        //먼저 interface 를 이용하여 데미지 를 주는 int 형 함수를 만든다.
        // 그런 다음 여러가지 몬스터를 만들어 각각의 몬스터 마다 플레이가 주는
        // 기본데미지 를 밸런스에 맞게 조정하면 플레이어가 사용하는 어택에서
        // 매개변수를 일일이 바꿀 필요 없이 한번에 코드를 정립이 가능하다
        int Damaged(int damage);
        //string Log(string log);
    }
}
