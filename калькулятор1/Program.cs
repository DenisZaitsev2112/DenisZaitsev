using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace калькулятор2
{
     class Program
    {
        static void Main(string[] args)
        {
            while (true)

            {
                Console.WriteLine(
  "Какое из действий вы хотите выполнить?: " + "\r\n" +
  "1. Сложить 2 числа " + "\r\n" +
  "2. Вычесть первое из второго " + "\r\n" +
  "3. Перемножить два числа " + "\r\n" +
  "4. Разделить первое на второе " + "\r\n" +
  "5. Возвести в степень N первое число " + "\r\n" +
  "6. Найти квадратный корень числа " + "\r\n" +
  "7. Найти 1 процент от числаm" + "\r\n" +
  "8. Найти факториал из числа " + "\r\n" +
  "9. Выйти из программы" + "\r\n" +
  "\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");

                int z = int.Parse(Console.ReadLine());

                switch (z)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите первое число ");
                            float a = float.Parse(Console.ReadLine());
                            Console.WriteLine("Введите второе число ");
                            float b = float.Parse(Console.ReadLine());
                            float x;
                            x = a + b;
                            Console.WriteLine("Ответ: " + x);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите первое число ");
                            float a = float.Parse(Console.ReadLine());
                            Console.WriteLine("Введите второе число ");
                            float b = float.Parse(Console.ReadLine());
                            float x;
                            x = a - b;
                            Console.WriteLine("Ответ: " + x);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите первое число ");
                            float a = float.Parse(Console.ReadLine());
                            Console.WriteLine("Введите второе число ");
                            float b = float.Parse(Console.ReadLine());
                            float x;
                            x = a * b;
                            Console.WriteLine("Ответ: " + x);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Введите первое число ");
                            float a = float.Parse(Console.ReadLine());
                            Console.WriteLine("Введите второе число ");
                            float b = float.Parse(Console.ReadLine());
                            float x;
                            x = a / b;
                            Console.WriteLine("Ответ: " + x);
                            break;
                        }
                    case 5:
                        {
                            Console.Write("Введите число: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.Write("Введите степень: ");
                            int n = int.Parse(Console.ReadLine());
                            int b = 1;
                            for (int i = 0; i < n; i++)
                            {
                                b *= a;
                            }
                            Console.WriteLine(" Ответ: {2}", a, n, b);
                            Console.ReadKey();
                            return;
                        }

                    case 6:
                        {
                            Console.Write("Введите число: ");
                            double x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ответ: {0} ", Math.Sqrt(x));
                            Console.ReadKey();
                            break;
                        }
                    case 7:
                        {
                            Console.Write("Введите число: ");
                            float a = Convert.ToInt32(Console.ReadLine());
                            float x;
                            x = a / 100;
                            Console.WriteLine("Ответ: " + x);

                            break;
                        }
                    case 8:
                        {
                            Console.Write("Введите число: ");
                            int x = Convert.ToInt32(Console.ReadLine());
                            int g = 1;
                            for (int i = 1; x >= i; ++i)
                            {
                                g = g * i;
                            }
                            Console.WriteLine("Ответ: " + g);
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Крнец работы." + "\r\n" + "Удачи");
                            Environment.Exit(0);
                            break;
                        }







                }
            }
        }
     }
}