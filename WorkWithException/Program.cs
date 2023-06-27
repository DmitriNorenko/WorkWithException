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
        delegate void Parents(Child sun);
        static void Main(string[] args)
        {
            Parents parents = ShowParent;
            parents.Invoke(new Child());
        }
        public static void ShowParent(Parent a)
        {
            Console.WriteLine(a.GetType());
        }
        public class Parent { }
        public class Child : Parent { }
    }
}

