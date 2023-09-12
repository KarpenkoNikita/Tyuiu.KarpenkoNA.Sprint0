using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KarpenkoNA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KarpenkoNA.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вызов класса DataService и метода GetVessage из библиотеки
            Console.WriteLine(DataService.GetMessage("Никита"));
            Console.ReadKey();
        }
    }
}
