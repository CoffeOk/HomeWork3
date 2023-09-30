/* На вход: Координаты двух точек
На выходе: Расстояние между ними в 3D пространстве */


double SMegduTchk3D (int a1, int a2, int b1, int b2, int c1, int c2)
{
    double a1a23D = Math.Sqrt (Math.Pow ((a2 - a1), 2) + Math.Pow ((b2 - b1), 2) + Math.Pow ((c2 - c1), 2));
    return a1a23D;
}

int x1, x2, y1, y2, z1, z2;

Console.Write ("Введите целое число x1: ");
while (!int.TryParse (Console.ReadLine(), out x1))
    Console.Write ("Ошибка ввода. Введите целое число: ");

Console.Write ("Введите целое число x2: ");
while (!int.TryParse (Console.ReadLine(), out x2))
    Console.Write ("Ошибка ввода. Введите целое число: ");

Console.Write ("Введите целое число y1: ");
while (!int.TryParse (Console.ReadLine(), out y1))
    Console.Write ("Ошибка ввода. Введите целое число: ");

Console.Write ("Введите целое число y2: ");
while (!int.TryParse (Console.ReadLine(), out y2))
    Console.Write ("Ошибка ввода. Введите целое число: ");

Console.Write ("Введите целое число z1: ");
while (!int.TryParse (Console.ReadLine(), out z1))
    Console.Write ("Ошибка ввода. Введите целое число: ");

Console.Write ("Введите целое число z2: ");
while (!int.TryParse (Console.ReadLine(), out z2))
    Console.Write ("Ошибка ввода. Введите целое число: ");

double smt3D = SMegduTchk3D (x1, x2, y1, y2, z1, z2);
Console.Write($"{Math.Round (smt3D, 2, MidpointRounding.ToZero)}");