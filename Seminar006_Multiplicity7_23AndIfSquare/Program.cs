//программа принимает на вход число и проверяет его кратность 7 И 23. Также программа принимает на вход 2 числа и проверяет является ли первое квадратом второго или второе квадратом первого

Console.WriteLine("Введите число для проверки кратности 7 и 23: ");
int Number = Convert.ToInt32(Console.ReadLine());
int Divider1 = 7;
int Divider2 = 23;

Console.WriteLine("Введите первое число для проверки является ли оно квадратом второго: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число для проверки является ли оно квадратом первого: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Проверка кратности 7 и 23.");
if (Number%Divider1 == 0 && Number%Divider2 == 0) Console.WriteLine(Number + "-> да");
else Console.WriteLine(Number + "-> нет");

Console.WriteLine("Проверка является ли число квадратом другого");
if (FirstNumber/SecondNumber == SecondNumber || SecondNumber/FirstNumber == FirstNumber)
{
    Console.WriteLine($"{FirstNumber}, {SecondNumber} -> да"); 
}
else Console.WriteLine($"{FirstNumber}, {SecondNumber} -> нет");


