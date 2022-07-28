//Рекурсия. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Введите M: ");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = Int32.Parse(Console.ReadLine());

Console.WriteLine(NaturalNumbers(m, n));

int NaturalNumbers(int startNumber, int endNumber)
{
    if (endNumber == startNumber)
        return startNumber;
    else if (endNumber > startNumber)
        Console.Write(NaturalNumbers(startNumber, endNumber - 1) + ", ");
    else if (endNumber < startNumber)
        Console.Write(NaturalNumbers(startNumber, endNumber + 1) + ", ");
    return endNumber;

}

