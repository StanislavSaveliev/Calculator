using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double onenumber, twonumber;
                string simvol;

                Console.WriteLine("Введите число 1");
                onenumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число 2");
                twonumber = double.Parse(Console.ReadLine());

                Console.WriteLine("Выберите операцию: '+','-','*','/'");
                simvol = Console.ReadLine();

                if (simvol == "+")
                {
                    Console.WriteLine(onenumber + twonumber);
                }
                else if (simvol == "-")
                {
                    Console.WriteLine(onenumber - twonumber);
                }
                else if (simvol == "*")
                {
                    Console.WriteLine(onenumber * twonumber);
                }
                else if (simvol == "/")
                {
                    if (twonumber == 0)
                    {
                        Console.WriteLine("Ошибка операции!");
                    }
                    else
                    {
                        Console.WriteLine(onenumber / twonumber);
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка! Выбрана не верная операция!");
                }
                Console.ReadLine();
            }          

        }
    }
}
