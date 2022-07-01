//программа с бесконечным циклом. При вводе пользователем слова exit программа заканчивается

string MagicWord = " ";

Console.WriteLine("Welcome to Eternity...Ha-ha-ha-ha-ha...");
while (2 > 1)
{
    MagicWord = Console.ReadLine();
    if (MagicWord.ToLower() == "exit") break;
}
