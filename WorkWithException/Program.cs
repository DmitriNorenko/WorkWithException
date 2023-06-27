using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithException
{
    internal class Program
    {
        public delegate void NumDelegate(int x, int y);
        static void Main(string[] args)
        {
            NumDelegate numDelegate = WorkWithNums;
            numDelegate += SumNums;
            numDelegate(15, 7);
        }
        public static void WorkWithNums(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public static void SumNums(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
}
