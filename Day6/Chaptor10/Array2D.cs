using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day6.Cahptor10
{
    public class Array2D : Print
    {
        public Array2D() 
        {
            //고정 길이방식
            int[,] arr2d = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            //가변길이 방식
            //int[][] = new int[2][];
            //Y축 배열
            for (int i = 0; i< arr2d.GetLength(0); i++)
            {
                //X축 배열
                for (int j = 0; j <arr2d.GetLength(1); j++)
                {
                    WriteSingle($"{i},{j} : {arr2d[i, j]}");

                }
                Write("");
            }
            Write("");

            /*
             i는 0,1까지 진행을 하고. j는 0,1,2 까지 진행을 합니다.
             - 1 2 3
             - 4 5 6
             처음 for문을들어가면 i = 0; j = 0; -> WriteSingle : 1을 출력
                               i = 0; j = 1; -> WriteSingle : 2을 출력
                               i = 0; j = 2; -> WriteSingle : 3을 출력
            j == 3이 되고 j<3 이 부분이 false가 되기떄문에 안 쪽에 있는 for문이 종료가 되서 밖으로 나옵니다.
            24번 라인에 Write(""); 가 실행이 됨 -> i가 1이 증가하고 i == 1 이됨
            다시 안쪽의 for문이 j == 0 으로 초기화되면서 안쪽 for문이 실행이 됩니다.
                               i = 0; j = 0; -> WriteSingle : 1을 출력
                               i = 1; j = 1; -> WriteSingle : 2을 출력
                               i = 2; j = 2; -> WriteSingle : 3을 출력
            j==3이 되고 j<3이 false가 되서 안쪽의 for문을 탈출합니다.
            24번 라인에 Write(""); 가 실행되고 i == 2 가 되지만 i<2가 false이기 때문에
            바깥의 for문도 탈출하게 되서 2중 for문이 종료됩니다.
             */
        }
    }
}
