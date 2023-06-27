using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithException
{
    internal class Program
    {
        delegate Car CarInfo();
        static void Main(string[] args)
        {
            CarInfo carInfo = lexus;
        }
        public static Car car()
        {
            return null;
        }
        public static Lexus lexus()
        {
            return null;
        }
        public class Car { }
        public class Lexus : Car { }
    }
}

