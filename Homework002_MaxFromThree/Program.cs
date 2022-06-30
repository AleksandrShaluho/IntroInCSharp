//Программа принимает на вход 3 числа и выдает максимальное из них

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b>max) max=b;
if (c>max) max=c;

Console.WriteLine(a + "," + b + "," + c + " ->" + max);
