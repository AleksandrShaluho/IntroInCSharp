//программа принимает на вход число и выдает сумму цифр в числк

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int tempNumber = number;
int sum = 0;

//в каждой итерации цикла определяем последнюю цифру числа путем деления с остатком и прибавляем ее к общей сумме в переменной sum
//затем отбрасываем отработанный разряд числа целочисленным делением
while (tempNumber > 1)
{
    sum+=tempNumber%10;
    tempNumber/=10;    
}

Console.WriteLine(number +"->" + sum);
