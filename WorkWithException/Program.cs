﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithException
{
    internal class Program
    {
        delegate void ShowMessageDelegate();
        delegate int SumDelegate(int x, int y, int z);
        delegate bool CheckLengthDelegate(string _row);
        static void Main(string[] args)
        {
            ShowMessageDelegate showMessageDelegate = ShowMessage;
            showMessageDelegate.Invoke();

            SumDelegate sumDelegate = Sum;
            int result = sumDelegate.Invoke(1, 30, 120);
            Console.WriteLine(result);

            CheckLengthDelegate checkLengthDelegate = CheckLength;
            bool status = checkLengthDelegate.Invoke("skill_factory");
            Console.WriteLine(status);
        }
        public static void ShowMessage()
        {
            Console.WriteLine("Hello World!");
        }

        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        public static bool CheckLength(string _row)
        {
            if (_row.Length > 3) return true;
            return false;
        }
    }
}
