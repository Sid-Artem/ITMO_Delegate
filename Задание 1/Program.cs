using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Program
    {

        delegate double MyDelegate(double x);

        static void Main(string[] args)
        {
            MyDelegate my = GetLengthCircle;
            my +=GetSquareCircle;
            my +=GetVolumeSphere;
            my(10);
            Console.ReadKey();

        }

        static double GetLengthCircle(double x)
        {
            double r= 2*Math.PI*x;
            Console.WriteLine(r);
            return r;
        }
        static double GetSquareCircle(double x)
        {
            double r = Math.PI * Math.Pow(x,2);
            Console.WriteLine(r);
            return r;
        }
        static double GetVolumeSphere(double x)
        {
            double r = (Math.PI*1.33333)* Math.Pow(x, 3);
            Console.WriteLine(r);
            return r;
        }


    }
}
