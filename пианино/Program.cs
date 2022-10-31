Console.WriteLine("ПИАНИНО");
Console.WriteLine("Клавиши диеза W,E,T,Y,U");
Console.WriteLine("Клавиши нот A,S,D,F,G,H,J");
Console.WriteLine("Клавиши переключение актав Escape, Tab, Delete");
Console.WriteLine("Включена первая актава!");
Console.WriteLine("Нажмите Enter для выхода");

int[] firstOctave = { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
while (true)
{
    ConsoleKeyInfo z;
    z = Console.ReadKey(true);
    switch (z.Key)
    {
        case ConsoleKey.Escape:
            Console.WriteLine("Октава номер 1");
            firstOctave = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
            break;
        case ConsoleKey.Tab:
            Console.WriteLine("Октава номер 2");
            firstOctave = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
            break;
        case ConsoleKey.Delete:
            Console.WriteLine("Октава номер 3");
            firstOctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            break;

        case ConsoleKey.A:
            Console.Beep(firstOctave[0], 250);
            break;
        case ConsoleKey.W:
            Console.Beep(firstOctave[1], 250);
            break;
        case ConsoleKey.S:
            Console.Beep(firstOctave[2], 250);
            break;
        case ConsoleKey.E:
            Console.Beep(firstOctave[3], 250);
            break;
        case ConsoleKey.D:
            Console.Beep(firstOctave[4], 250);
            break;
        case ConsoleKey.F:
            Console.Beep(firstOctave[5], 250);
            break;
        case ConsoleKey.T:
            Console.Beep(firstOctave[6], 250);
            break;
        case ConsoleKey.G:
            Console.Beep(firstOctave[7], 250);
            break;
        case ConsoleKey.Y:
            Console.Beep(firstOctave[8], 250);
            break;
        case ConsoleKey.H:
            Console.Beep(firstOctave[9], 250);
            break;
        case ConsoleKey.U:
            Console.Beep(firstOctave[10], 250);
            break;
        case ConsoleKey.J:
            Console.Beep(firstOctave[11], 250);
            break;
        case ConsoleKey.Enter:
            Console.WriteLine("Крнец работы." + "\r\n" + "Спасибо Дзюбе");
            Environment.Exit(0);
            break;
    }
}