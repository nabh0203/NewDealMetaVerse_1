using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day6.Cptor10
{
    //일반화를 하기 위해서는 클래스명 뒤에 <T>를 무조건으로 붙여야 한다
    class MyGenericList<T>
    {
        private T[] array;

        public MyGenericList()
        {
            array = new T[3];
        }

        public T this[int index]
        {
            get { return array[index]; }
            set
            {
                if(index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Debug.WriteLine($"Array Resize : {array.Length}");
                }

                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }
    }

    public class Generic : Print
    {
        public Generic()
        {


            MyGenericList<int> int_list = new MyGenericList<int>();
            int_list[0] = 10;
            int_list[1] = 20;
            int_list[2] = 30;
            int_list[3] = 40;
            int_list[4] = 50;
            int_list[10] = 100;


            for (int i = 0; i < int_list.Length; i++)
            {
                WriteSingle(int_list[i]);
            }
            Write("");

            MyGenericList<string> str_list = new MyGenericList<string>();
            str_list[0] = "a";
            str_list[1] = "b";
            str_list[2] = "c";
            str_list[3] = "d";
            str_list[4] = "e";
            str_list[5] = "f";

            for (int i = 0; i < str_list.Length; i++)
            {
                WriteSingle(str_list[i]);
            }
            Write("");
        }
    }
} 


