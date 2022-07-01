//программа принимает на вход трехзначное число и на выходе показывает вторую цифру числа

Console.WriteLine("Введите трехзначное положительное число: ");
int Number = Convert.ToInt32(Console.ReadLine());

int SecondDigit = Number%100/10;

Console.WriteLine($"{Number} -> {SecondDigit}");

