using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day6.Cahptor9
{
    public class BirthDayinfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get 
            { 
                return name; 
            }
            set
            {
                if(name != value) 
                {

                    name = value;
                } 
            }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            //private set 으로 설정하면 외부에서 값을 조정할수 없다.
            set
            {
                if(birthday != value)
                {
                    birthday = value;
                }
            }
        }


        public int Age
        {
            get
            {
                //DateTime 를 사용하여 입력한 값으로 부터 오늘 날짜의 값중 연도의 값을 구하여
                //오늘의 날짜에서 입력한값을 Subtract(빼다) 와 Ticks을 활용하여
                //나이를 구하는 함수이다.
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }
    public class PropertyEx : Print
    {
        public PropertyEx()
        {
            BirthDayinfo birth = new BirthDayinfo();
            birth.Name = "병호";
            //birth.Name = "병호";
            //birth.Name = "나병호";
            birth.Birthday = new DateTime(2001, 02, 03);

            //아래처럼 정보를 미리 입력하여 사용할 수 있음
            //BirthDayinfo birth2 = new BirthDayinfo()
            //{
            //    Name = "나병호",
            //    Birthday = new DateTime(2001, 02, 03);
            //};
            


            string UserName = birth.Name;
            DateTime DateTim = birth.Birthday;
            //아래 처럼 Age 에 값을 넣지 못하는 이유는 Age 메서드에서 Set 이 구현이 안되어 있기 때문
            //birth.Age = 30;
            Write($"Name : {birth.Name}");
            Write($"BirthDay : {birth.Birthday.ToShortDateString()}");
            Write($"Age : {birth.Age}");
            Write($"DateTime.Now : {DateTime.Now}");
        }
    }
}
