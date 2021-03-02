using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMySin
{
    class Program
    {
        /// <summary>
        /// Виклик бібліотечного метода Sin(x,n) з MySin.dll
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х= угол в радианах");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите показатель степени n");
            int n = int.Parse(Console.ReadLine());
            //вызов метода вычисления sin(x) из библиотеки
            double my_sinus = MyLib.MySin.Sin(x, n);
            //вызов метода из класса Math
            double sinus = Math.Sin(x);
            double delta = sinus - my_sinus;
            Console.WriteLine("my_sinus= {0},sin={1},delta={2}", my_sinus, sinus, delta);
            Console.ReadKey();
        }
    }
}