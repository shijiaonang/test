using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer1
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            double x, y;
            string m,n,h,w;
            Console.WriteLine("输入第一个数");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("输入要进行的操作：+,-,*,/");
            t = Console.ReadLine();
            Console.WriteLine("输入第二个数");
            y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("{0},{1},{2}",x, y, t);
            
            if(t=="+")
            {
                jia a = new jia();
                a.task(x,y);
                Console.WriteLine("输入两个需要连接的字符串");
                m = Console.ReadLine();
                n = Console.ReadLine();
                connect con = new connect();
                con.task(m, n);
            }else if(t=="-")
            {
                jian b = new jian();
                b.task(x, y);
                Console.WriteLine("输入两个需要删除的字符串，第一个为母字符串，第二个为子字符串");
                h = Console.ReadLine();
                w = Console.ReadLine();
                Delect delect = new Delect();
                delect.task(h, w);
            }
            else if(t=="*")
            {
                cheng c = new cheng();
                c.task(x, y);
            }else if(t=="/")
            {
                chu d = new chu();
                d.task(x, y);
            }
            else
            {
                Console.WriteLine("输入错误");
            }
        }
    }
}
