//Программа принимает на вход 2 числа и сообщает какое из них больше, а какое меньше

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b) Console.WriteLine("a=" + a +"; b=" + b + " -> max=" + a);
if (a<b) Console.WriteLine("a=" + a +"; b=" + b + " -> max=" + b);
if (a==b) Console.WriteLine("a=" + a +"; b=" + b + " -> числа равны");
