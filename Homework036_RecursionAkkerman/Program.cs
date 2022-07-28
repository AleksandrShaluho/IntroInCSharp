//Рекурсия.  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите M: ");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = Int32.Parse(Console.ReadLine());

Console.WriteLine($"Значение функции Аккермана составляет {Akkerman(m, n)}");

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else if (m > 0 && n > 0)
        return Akkerman(m - 1, Akkerman(m, n - 1));
    else
        return 1;
}
