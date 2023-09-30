/* Принимает пятизначное число
Проверяет является ли оно полиндромом */


bool Polindrom(int num)
{
    int revers, x;
    revers = 0;
    while (num != 0)
    {
        x = num % 10;
        revers = revers * 10 + x;
        num /= 10;
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
    Console.Write($"{n} -> Да");
else
    Console.Write($"{n} -> Нет");
