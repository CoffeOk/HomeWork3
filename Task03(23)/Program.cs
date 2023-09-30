/* На вход число num
На выходе таблица кубов от 1 до n */


void TableKub (int num)
{
    for (int i = 0; i <= num; i++)
    {
        Console.WriteLine ($"{i,3} | {Math.Pow (i,3), 6}");
    }
}

int n;

Console.Write ("Введите целое число n: ");
while (!int.TryParse (Console.ReadLine(), out n))
    Console.Write ("Ошибка ввода. Введите целое число: ");

TableKub (n);
