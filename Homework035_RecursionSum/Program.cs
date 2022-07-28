//Рекурсия. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите M: ");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = Int32.Parse(Console.ReadLine());

Console.WriteLine($"Сумма чисел от {m} до {n} составляет {NaturalSum(m, n)}");

int NaturalSum(int startNumber, int endNumber)
{
    if (endNumber == startNumber)
        return endNumber;
    else if (endNumber > startNumber)
        return startNumber + NaturalSum(startNumber + 1, endNumber);
    else
        return startNumber + NaturalSum(startNumber - 1, endNumber);
}

