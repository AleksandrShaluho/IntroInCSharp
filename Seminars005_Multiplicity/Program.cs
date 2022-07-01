//программа принимает на вход два числа и выводит, является ли ПЕРВОЕ кратным второму

Console.WriteLine("Введите первое число: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

int Remainder = FirstNumber%SecondNumber;

if (Remainder == 0) Console.WriteLine($"{FirstNumber},{SecondNumber}-> кратно");
else Console.WriteLine($"{FirstNumber},{SecondNumber}-> не кратно, остаток {Remainder}"); 
