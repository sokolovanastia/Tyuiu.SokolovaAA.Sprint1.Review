using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SokolovaAA.Sprint1.TaskReview.V5.Lib;
namespace Tyuui.SokolovaAA.Sprint1.TaskReview.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (Math.Abs(Math.Cos(x)) == 1)   
            {
                Console.WriteLine("Данное значение x недопустимо, так как аргумент логарфима не должен быть равен единице!!!!");

            }
            else if (Math.Abs(Math.Cos(x)) == 0)
            {
                Console.WriteLine("Данное значение x недопустимо, так как аргумент логарфима не может быть равен нулю!!!!");
            }
            else if (x == 0)
            {
                Console.WriteLine("Данное значение x недопустимо, так как аргумент логарфима не должен быть равен единице!!!!");
            }
            else
            {
                Console.WriteLine("Результат: " + ds.Calculate(x));
            }
            Console.ReadKey();
        }
    }
}
