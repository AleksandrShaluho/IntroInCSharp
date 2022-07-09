//эта задача сделана на базе предыдущих задач про игру-угадайку и программу, завершающуюся при вводе команды exit
//добавить к программе еще 4 команды (можно придумать самому). Например: SetName, Help, Set Password, WruteName

//инициализируем переменные для записи команды от пользователя, имени и пароля
string userCommand = String.Empty;
string userName = String.Empty;
string userPass = String.Empty;

//приветственная строка, поясняющая, что делать в программе
Console.WriteLine("Привет. Вы в игре Угадай-ка. Введите, пожалуйста, команду. Для просмотра списка доступных команд введите 'help'.");

//вечный цикл, чтобы держать пользователя в программе, пока он не напишет команду exit
while(true)
{
//на старте пользователь должен ввести какую-либо команду, поэтому анализируем какую команду он ввел
//рискну здесь применить оператор switch и отдельные методы под каждую команду, т.к. набор действий в этих командах может расширяться потом. Альтернативно можно написать код с оператором if-else    
    userCommand = Console.ReadLine();
    switch(userCommand.ToLower())
    {
        case "exit":
            return;
        case "start":
            if (userName == "") Console.WriteLine("Я вас не знаю. Перед началом игры выполните команду setname");
            else Start(userName);
            break;
        case "setname":
            userName = SetName();
            Console.WriteLine("Привет, " + userName);
            break;
        case "setpass":
            if (userName =="") Console.WriteLine("Я вас не знаю. Перед установкой пароля выполните команду setname");
            else 
            {
                userPass = SetPass(userName);
                Console.WriteLine(userName + ", ваш пароль установлен");
            }
            break;
        case "writename":
            WriteName(); 
            break;
        case "help":
            Help();
            break;
//если пользователь ошибся с командой, программа по умолчанию будет на это реагировать сообщением об ошибочном действии.
        default:
            Console.WriteLine($"Неизвестная или неправильная команда {userCommand}. Для получения списка доступных команд введи 'help'");
            break;
    }
    Console.WriteLine("Введите команду: ");
}

//алгоритм самой угадай-ки вынес в отдельный метод. Мне кажется так удобнее работать с кодом. 
void Start(string userName)
{
//загадываем число от 1 до 10
    int secretNumber = new Random().Next(1,11);
//максимальное количество попыток в игре
    int maxAttemptNumber = 3;
//инициализация переменной для хранения ответов пользователя в игре
    int guessNumber = 0;
  
    Console.WriteLine($"{userName}, я загадал число от 1 до 10. Отгадай! Введи число: ");
//в цикле даем пользователю угадывать число в течение 3 попыток. Число доступных попыток с каждым разом уменьшается.    
    while (maxAttemptNumber > 0)
    {
        guessNumber = Convert.ToInt32(Console.ReadLine());
        if (guessNumber == secretNumber)  
        {
            Console.WriteLine($"Молодец, {userName}. {guessNumber} - это правильный ответ!");
            break;
        }
        else
        {
            maxAttemptNumber--;
            if (guessNumber > secretNumber) Console.WriteLine($"Неверно. Загаданное число меньше {guessNumber}.Осталось {maxAttemptNumber} попытки.");
            else Console.WriteLine($"Неверно. Загаданное число больше {guessNumber}. Осталось {maxAttemptNumber} попытки.");
        }
        if (maxAttemptNumber == 0) Console.WriteLine($"{userName}, к сожалению, все, попытки кончились. Правильный ответ был {secretNumber}");
    } 
}

//метод для установки имени пользователя
string SetName()
{
    Console.WriteLine("Введите свое имя: ");
    return Console.ReadLine();
}

//метод для установки пароля
string SetPass(string user)
{
    string pass = String.Empty;
    string checkpass = String.Empty;
    
//проверяем что пользователь ввел тот пароль, который хотел
    while (pass !=checkpass  || checkpass=="")
    {
        Console.WriteLine($"Введите новый пароль для пользователя {user}: ");
        pass = Console.ReadLine();
        Console.WriteLine("Повторите пароль ");
        checkpass = Console.ReadLine();
        if(pass != checkpass) Console.WriteLine("Пароли не совпадают. Повторите команду заново");
    }
//возвращаем строку с паролем
    return pass;
}

//метод для вывода имени пользователя по паролю
void WriteName()
{
    Console.WriteLine("Введите пароль: ");
    if(Console.ReadLine() == userPass) Console.WriteLine("Имя текущего пользователя - " + userName);
    else Console.WriteLine("Вы ввели неверный пароль или пароль не был установлен."); 
}

//метод для вывода списка всех команд
void Help()
{
        Console.WriteLine("Список доступных команд:");
        Console.WriteLine("    help - получение списка команд;");
        Console.WriteLine("    exit - выход из программы;");
        Console.WriteLine("    start - начать новую игру;");
        Console.WriteLine("    setname - записать имя текущего пользователя;");
        Console.WriteLine("    setpass - установить пароль для текущего пользователя;");
        Console.WriteLine("    writename - вывести имя текущего пользователя;");        
}
