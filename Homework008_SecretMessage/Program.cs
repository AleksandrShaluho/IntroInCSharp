//в переменной string есть секретное сообщение, во второй - пароль. Пользователю программы дается 3 попытки ввести пароль и увидеть секретное сообщение.

string Secret = "Поздравляю. Ты - избранный. Тебя выбрала сама Матрица. Если ты будешь и дальше тренироваться, то сможешь зафиксисть все баги Матрицы и стать Мастером ключей";

string Pass = "A#w#xl?oSyjE";
string NeoPass = " ";
int MaxAttemptNumber = 3;

while (MaxAttemptNumber > 0)
{
    Console.WriteLine($"У тебя есть только {MaxAttemptNumber} попытки, Нео. Вводи пароль: ");
    Console.CursorVisible = true;
    NeoPass = Console.ReadLine();
    if (NeoPass == Pass) 
    {
        Console.WriteLine(Secret);
        break;
    }
    MaxAttemptNumber--;
    if (MaxAttemptNumber == 0) Console.WriteLine("Все кончено, Нео. Агент Смит нас вычислил");
}
