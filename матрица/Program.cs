using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Угадай число ");
            Console.WriteLine("2. Вывод делителей числа ");
            Console.WriteLine("3. Таблица умножения");
            Console.WriteLine("4. Закрыть программу ");
            while (true)
            {
                Console.WriteLine("------------------------------------ ");
                Console.WriteLine("Какое действие вы хотите выполнить ? ");
                int action = Convert.ToInt32(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        {

                            Random random = new Random();
                            int n = random.Next(1, 200);

                            int count = 0;
                            string str;

                            do
                            {
                                Console.Write("Введите число: ");
                                str = Console.ReadLine();


                                if (int.Parse(str) < n)
                                    Console.WriteLine("Задуманное число больше");
                                if (int.Parse(str) > n)
                                    Console.WriteLine("Задуманное число меньше");

                                count++;
                            }
                            while (int.Parse(str) != n);

                            Console.WriteLine("Вы угадали", count);
                            Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Введи число: ");
                            int n = int.Parse(Console.ReadLine());
                            for (int a = 1; a <= n; a++)
                            {
                                if (n % a == 0)
                                    Console.Write("{0}", a + "\n");
                            }
                            break;
                        }
                    case 3:
                        {
                            for (int n = 1; n <= 10; n++)
                            {
                                for (int o = 1; o <= 10; o++)
                                {
                                    Console.Write(n * o + "\t");
                                }
                                Console.WriteLine();
                            }
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Досвидос");
                            Environment.Exit(0);
                            break;
                        }
                }
                Console.WriteLine("Нажмите Enter для выбора других функций");
                Console.ReadKey();
            }
        }
    }
}