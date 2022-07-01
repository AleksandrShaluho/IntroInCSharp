//программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет

//число на вход. Диапазон для простоты ограничим, но алгоритм должен работать со всеми целыми числами
int Number = new Random().Next(1,100000);

//Простой способ

if (Number < 100) Console.WriteLine(Number + "-> Третьей цифры нет");
else 
{
    int ThirdDigit = Number;

    while (ThirdDigit > 999) 
    {
        ThirdDigit = ThirdDigit/10;
    }
    
    Console.WriteLine(Number + "-> " + ThirdDigit%10);
}

