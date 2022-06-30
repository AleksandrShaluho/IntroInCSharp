//Программа принимает на вход 2 целых числа и проверяет является ли ВТОРОЕ квадратом первого

Console.Write("Введите первое число: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

if (SecondNumber == FirstNumber*FirstNumber) Console.WriteLine("a=" + FirstNumber + ";b=" + SecondNumber + "-> ДА");
else Console.WriteLine("a=" + FirstNumber + ";b=" + SecondNumber + "-> НЕТ");
