//игра-угадайка. Программа загадывает случайное число. Пользователь его угадывает. Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше. На отгадываение дается 3 попытки.

//загадываем число от 1 до 10
int secretNumber = new Random().Next(1,11);
int maxAttemptNumber = 3;
int guessNumber = 0;

Console.WriteLine("Я загадал число от 1 до 10. Отгадай! Введи число: ");

while (maxAttemptNumber > 0)
{
    guessNumber = Convert.ToInt32(Console.ReadLine());
    if (guessNumber == secretNumber)  
    {
        Console.WriteLine($"Молодец, {guessNumber} это правильный ответ!");
        break;
    }
    else
    {
        maxAttemptNumber--;
        if (guessNumber > secretNumber) Console.WriteLine($"Неверно. Загаданное число меньше {guessNumber}.Осталось {maxAttemptNumber} попытки.");
        else Console.WriteLine($"Неверно. Загаданное число больше {guessNumber}. Осталось {maxAttemptNumber} попытки.");
    }
    if (maxAttemptNumber == 0) Console.WriteLine("Все, попытки кончились. Ты проиграл...");
}
