using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithException
{
    internal class Program
    {
        delegate void ShowMessageDelegate(string _message);
        static void Main(string[] args)
        {
            ShowMessageDelegate showMessageDelegate = delegate (string message)
            {
                Console.WriteLine(message);
            };
            showMessageDelegate.Invoke("Hello World!");
            Console.Read();
        }
    }
}
