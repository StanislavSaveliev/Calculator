using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_1
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

                try
                {
                    Console.WriteLine("Введите число 1");
                    onenumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число 2");
                    twonumber = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Не верно введены данные!");
                    Console.ReadLine();
                    continue;
                }                

                Console.WriteLine("Выберите операцию: '+','-','*','/'");
                simvol = Console.ReadLine();

                switch (simvol)
                {
                    case "+":
                        Console.WriteLine(onenumber + twonumber);
                        break;

                    case "-":
                        Console.WriteLine(onenumber - twonumber);
                        break;

                    case "*":
                        Console.WriteLine(onenumber * twonumber);
                        break;

                    case "/":
                        if (twonumber == 0)
                        {
                            Console.WriteLine("Ошибка операции!");
                        }
                        else
                        {
                            Console.WriteLine(onenumber / twonumber);
                        }
                        break;

                    default:
                        Console.WriteLine("Ошибка операции!");
                        break;
                        
                }
                Console.ReadLine();

            
            }
        }
        
    }
}
