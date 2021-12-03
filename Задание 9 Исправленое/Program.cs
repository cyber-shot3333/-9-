using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9_Исправленое
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int a, b;
                string c;
                Console.WriteLine("Калькулятор C#");
                Console.WriteLine("------------------------");
                try
                {
                    Console.WriteLine("Введи число №1 и нажми Enter");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введи число №2 и нажми Enter");
                    b = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Ошибка! {0}", ex.Message);
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine("Выбери действия с числами №1 и №2 из следующего списка:");
                Console.WriteLine(" + - Сложить");
                Console.WriteLine(" - - Вычесть");
                Console.WriteLine(" * - Умножить");
                Console.WriteLine(" / - Разделить");
                Console.Write("Ваш выбор?");
                c = Console.ReadLine();
                switch (c)
                {
                    case "+":
                        Console.WriteLine("Ваш результат: a + b = {0}", a + b);
                        break;
                    case "-":
                        Console.WriteLine("Ваш результат: a - b = {0}", a - b);
                        break;
                    case "*":
                        Console.WriteLine("Ваш результат: a * b = {0}", a * b);
                        break;
                    case "/":
                        try
                        {
                            Console.WriteLine("Ваш результат: a / b = {0}", a / b);
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;                   
                }
                Console.Write("Нажми любую кнопку чтобы закрыть Калькулятор C#");
                Console.ReadKey();
            }
        }
    }
}


