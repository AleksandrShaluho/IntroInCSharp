//эта задача сделана на базе предыдущих задач про игру-угадайку и программу, завершающуюся при вводе команды exit
//добавить к программе еще 4 команды (можно придумать самому). Например: SetName, Help, Set Password, WruteName
string userCommand = String.Empty;
string userName = String.Empty;
string userPass = String.Empty;

Console.WriteLine("Привет. Вы в игре Угадай-ка. Введите, пожалуйста, команду. Для просмотра списка доступных команд введите 'help'.");

while(true)
{
  userCommand = Console.ReadLine();
  switch(userCommand.ToLower())
  {
    case "exit":
         return;
    case "newgame":
      if (userName == "")
        Console.WriteLine("Я вас не знаю. Перед началом игры выполните команду setname");
      else NewGame(userName);
        break;
    case "setname":
      userName = SetName();
      Console.WriteLine("Привет, " + userName);
      break;
    case "setpass":
      if (userName =="") 
      {      
        Console.WriteLine("Я вас не знаю. Перед установкой пароля выполните команду setname");
      }
      else 
      {
        userPass = SetPass(userName);
        Console.WriteLine(userName + ", ваш пароль установлен");
      }
      break;
    case "writename":
      if (userPass =="") 
      {      
        Console.WriteLine("Я вас не знаю. Сначала нужно установить имя пользователя и пароль.");
      }
      else 
        WriteName(); 
      break;
    case "help":
      Help();
      break;
    default:
      Console.WriteLine($"Неизвестная или неправильная команда {userCommand}. Для получения списка доступных команд введи 'help'");
      break;
  }
  Console.WriteLine("Введите команду: ");
}

void NewGame(string userName)
{
  int secretNumber = new Random().Next(1,11);
  int maxAttemptNumber = 3;
  int guessNumber = 0;
  
  Console.WriteLine($"{userName}, я загадал число от 1 до 10. Отгадай! Введи число: ");
    
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
      if (guessNumber > secretNumber) 
        Console.WriteLine($"Неверно. Загаданное число меньше {guessNumber}.Осталось {maxAttemptNumber} попытки.");
      else 
        Console.WriteLine($"Неверно. Загаданное число больше {guessNumber}. Осталось {maxAttemptNumber} попытки.");
    }
    if (maxAttemptNumber == 0) 
      Console.WriteLine($"{userName}, к сожалению, все, попытки кончились. Правильный ответ был {secretNumber}");
  } 
}

string SetName()
{
  Console.WriteLine("Введите свое имя: ");
  return Console.ReadLine();
}

string SetPass(string user)
{
  string pass = String.Empty;
  string checkpass = String.Empty;
    
  while (pass !=checkpass  || checkpass=="")
  {
    Console.WriteLine($"Введите новый пароль для пользователя {user}: ");
    pass = Console.ReadLine();
    Console.WriteLine("Повторите пароль ");
    checkpass = Console.ReadLine();
    if(pass != checkpass)
       Console.WriteLine("Пароли не совпадают. Повторите команду заново");
  }
  return pass;
}

void WriteName()
{
  Console.WriteLine("Введите пароль: ");
  if(Console.ReadLine() == userPass)
    Console.WriteLine("Имя текущего пользователя - " + userName);
  else 
    Console.WriteLine("Вы ввели неверный пароль."); 
}

void Help()
{
  Console.WriteLine("Список доступных команд:");
  Console.WriteLine("    help - получение списка команд;");
  Console.WriteLine("    exit - выход из программы;");
  Console.WriteLine("    newgame - начать новую игру;");
  Console.WriteLine("    setname - записать имя текущего пользователя;");
  Console.WriteLine("    setpass - установить пароль для текущего пользователя;");
  Console.WriteLine("    writename - вывести имя текущего пользователя;");        
}
