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
            Exception exception = new Exception("Ошибка");
            exception.Data.Add("Дата создания исключения: ",DateTime.Now);
            exception.HelpLink= "https://www.youtube.com";
        }
    }
}
