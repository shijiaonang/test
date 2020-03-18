using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer1
{
    class Delect:jian
    {
        public void task(string x,string y)
        {
            string str,stt;
            int a = y.Length;
            for(int i=1;i<x.Length+1;i++)
            {
                if (y == x.Substring(i, a))
                {
                    str = x.Substring(0, i);
                    stt = x.Substring(i + a );
                    Console.WriteLine(str);
                    Console.WriteLine(str+stt);
                    break;
                }
            }
        }
    }
}
