using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Блок try сработал.");
                throw new ArgumentOutOfRangeException();
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Блок catch сработал.");
                Console.WriteLine("Вы вышли за пределы допустимых значений.");
            }
            finally
            {
                Console.WriteLine("Блок Finally сработал!");
            }
            Console.ReadKey();
        }
    }
}
