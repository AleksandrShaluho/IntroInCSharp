//программа принимает на вход числа А и В и возводит А в натуральную степень В
//в решении будем использовать 2 собственных метода: InputInt для ввода числа и Pow - для вычисления степени (все методы в конце текста программы)

//основная часть
int number = InputInt("Введите число: ");
int powInt = InputInt("Введите степень в виде натурального числа: ");

//проверка является ли степень натуральным числом и вывод результата
if (powInt < 0) Console.WriteLine("Степень должна быть натуральным числом");
else Console.WriteLine($"{number},{powInt} -> {Pow(number,powInt)}");

//метод InputInt позволяет выводить приглашение для ввода и получать число от пользователя
int InputInt(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}

//метод Pow вычисляет заданную степень числа
double Pow(double number, int powNumber)
{
   int count = 1;
   double pow = 1;    
   while (count <= powNumber)
   {
       pow*=number;
       count++;
   }
   return pow;
}
