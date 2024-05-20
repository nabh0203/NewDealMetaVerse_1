using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDealMetaverse
{
    public class Print : IPrint
    {
        public string printData = null;

        public void Write(object o)
        {
            printData += o.ToString() + "\r\n";
        }

        public string GetData()
        {
            string value = printData;
            printData = null;

            return value;
        }
    }
}
