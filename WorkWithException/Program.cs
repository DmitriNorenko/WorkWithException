using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithException
{
    internal class Program
    {
        public delegate int NumDelegate(int x, int y);
        static void Main(string[] args)
        {
            NumDelegate numDelegate = WorkWithNums;
            int result = numDelegate(15, 7);
            Console.WriteLine(result);
            int result2 = numDelegate.Invoke(15, 7);
            Console.WriteLine(result2);
        }
        public static int WorkWithNums(int x, int y)
        {
            return x - y;
        }
    }
}
