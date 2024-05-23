using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse.Day8
{
    public class StringFunction
    {
        public StringFunction()
        {
            string greeting = "Good Morning";

            //Debug.WriteLine(greeting);
            //Debug.WriteLine(greeting.Length);

            //for(int i = 0; i < greeting.Length; i++)
            //{
            //    char c = greeting[i];
            //    Debug.WriteLine(c);
            //}

            int index0 = greeting.IndexOf('o');
            Debug.WriteLine(index0);
            int Lastindex0 = greeting.LastIndexOf('o');
            Debug.WriteLine(Lastindex0);

            bool isContain = greeting.Contains("Good");
            Debug.WriteLine(isContain);

            greeting.Replace("Morning", "Evening");
            Debug.WriteLine(greeting);

            greeting = greeting.Replace("Morning", "Evening");
            Debug.WriteLine(greeting);

            greeting = greeting.ToLower();
            Debug.WriteLine(greeting);

            string strFormat = string.Format("Trim() : {0}", "No Spaces".Trim());
            Debug.WriteLine(strFormat);


            string path = "C:\\Data\\NewDeal.json";
            path = @"C:\\Data\\A\\2024\\326\\NewDeal.json";
            string[] splitpath = path.Split("\\");

            for (int i = 0; i < splitpath.Length; i++)
            { Debug.WriteLine(splitpath[i]); }
            string fileName1 = splitpath[splitpath.Length - 1];
            string fileName2 = splitpath[^1];

            //Nullalbe
            string nullableStr = null;
            int? nullablenum = null;

            //nullablenum?.Tostirng();
        }
    }
}
