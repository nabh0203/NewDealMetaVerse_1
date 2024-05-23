using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day7.Chaptor11
{
    //2차원 List 배열
    public class UsingList2D : Print
    {
        public UsingList2D() 
        { 
            //List<List<타입>> 변수명 = new List<List<타입>>();
            List<List<string>> list2d = new List<List<string>>();
            
            List<string> index1Data = new List<string>();
            index1Data.Add("데이터 1,1");
            index1Data.Add("데이터 1,2");

            List<string> index2Data = new List<string>();
            index2Data.Add("데이터 2,1");
            index2Data.Add("데이터 2,2");
            index2Data.Add("데이터 2,3");


            List<string> index3Data = new List<string>();
            index3Data.Add("데이터 3,1");

            list2d.Add(index1Data);
            list2d.Add(index2Data);
            list2d.Add(index3Data);

            //Write(list2d[0][0]);
            
            //행 3개 / 열의개수는 행마다 다릅니다.
            //1행 : 2개의 열 / 2행 : 3개의 열 / 3행 : 1개의 열

            //list2d 배열 갯수 확인
            for (int i = 0; i < list2d.Count ; i++)
            {
                //list2d 자식 배열 갯수 확인
                for (int j = 0; j < list2d[i].Count ; j++)
                {
                    //각행의 열에 저장되어있는 데이터를 출력하는 코드
                    WriteSingle($"[{i},{j}] : {list2d[i][j]}");
                }
                Write("");
            }

        }
    }
}
