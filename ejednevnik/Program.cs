using System;
using System.ComponentModel.Design;

System.DateTime date = new System.DateTime(2022, 11, 4);

/*int year = date.Year;
int month = date.Month;
int day = date.Day;
как сделать так, чтобы мои заметки
не переносились на тот же день,
но следующего месяца?*/

int pos = 1;

Console.WriteLine(date);
while (true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.UpArrow)
    {
        pos--;
    }
    if (key.Key == ConsoleKey.DownArrow)
    {
        pos++;
    }
    if (key.Key == ConsoleKey.LeftArrow)
    {
        date = date.AddDays(-1);
        Console.WriteLine(date);
    }
    if (key.Key == ConsoleKey.RightArrow)
    {
        date = date.AddDays(+1);
        Console.WriteLine(date);
    }
    if (date.Day == 5)
    {
        Console.WriteLine(date);
        Console.Clear();
        Console.WriteLine(date);
        onezadanie();
        if (key.Key == ConsoleKey.Enter)
        {
            if (pos == 1)
            {
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("   Прийти в магазин, охренеть от цен и уйти");
                Console.WriteLine("------------------------------------");
            }
            else if (pos == 2)
            {
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("   Открыть холодильник, понять что нихрена нет и купить себе пиво");
                Console.WriteLine("------------------------------------");
            }
        }
    }
    if (date.Day == 5)
    {
        Console.WriteLine(date);
        Console.Clear();
        Console.WriteLine(date);
        vtozadanie();
        if (key.Key == ConsoleKey.Enter)
        {
            if (pos == 1)
            {
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("   Сесть за стол, открыть тетрадь с заданиями, а не кс! ");
                Console.WriteLine("------------------------------------");
            }
            else if (pos == 2)
            {
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("   Лечь спать не позже 00:00, а не в 5:59");
                Console.WriteLine("------------------------------------");
            }
        }
    }
    Console.SetCursorPosition(0, pos);
    Console.WriteLine("->");
}

static void onezadanie()
{
    Console.WriteLine("   Пойти в мазин за зимней курткой");
    Console.WriteLine("   Приготовить покушать");
}

static void vtozadanie()
{
    Console.WriteLine("   Сделать дискретку");
    Console.WriteLine("   Не проспать занятия");
}
