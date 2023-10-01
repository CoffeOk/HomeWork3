/* Принимает пятизначное число
Проверяет является ли оно полиндромом */


bool Polindrom(int num)
{
    int revers, x, numb;
    revers = 0;
    numb = num;
    while (numb != 0)
    {
        x = numb % 10;
        revers = revers * 10 + x;
        numb /= 10;
    }
    if (num != revers) return false;
    return true;
}

int n;

Console.Write("Введите целое число n: ");
while(!int.TryParse(Console.ReadLine(), out n))
    Console.Write("Ошибка ввода. Введите целое число: ");

bool number = Polindrom(n);
if (number != true)
    Console.Write($"{n} -> Нет");
else
    Console.Write($"{n} -> Да");

/* using System;

public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {
      // Введите свое решение ниже
    double distance = Math.Sqrt(Math.Pow((pointA[0] - pointB[0]), 2) + Math.Pow((pointA[1] - pointB[1]), 2) + Math.Pow((pointA[2] - pointB[2]), 2));
return distance;
    }

  // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args) {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6) {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        // Не удаляйте строки ниже
        double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        Console.WriteLine($"{result:F2}");
    }
} */