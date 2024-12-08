using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_1
{
    internal class Program
    {
        delegate int MyDelegate(int a, int b);
        static void Main(string[] args)
        {
            //MyDelegate myDelegate = PowerAB;
            //int r =myDelegate(2, 10);
            //Console.WriteLine(r);

            //MyDelegate myDelegate1= PowerBA;
            //int y = myDelegate1(2, 10);
            //Console.WriteLine(y);
            MyDelegate myDelegate = PowerAB;
            myDelegate += PowerBA;
            myDelegate(2, 10);
            Console.ReadKey();

        }
        static int PowerAB(int a, int b)
        {

            int r = (int)Math.Pow(a, b);
            Console.WriteLine(r);
            return r;
        }
        static int PowerBA(int a, int b)
        {

            int r = (int)Math.Pow(b, a);
            Console.WriteLine(r);
            return r;
        }



    }
}
