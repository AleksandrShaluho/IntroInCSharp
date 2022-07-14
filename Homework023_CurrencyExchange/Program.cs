//конвертер валют. У пользователя есть баланс в каждой из представленных валют. С помощью команд он может попросить сконвертировать одну валюту в другую. Курс конвертации просто описать в программе. Программа заканчивает свою работу в момент, когда решит пользователь
string userCommand = String.Empty;
string[,] currencyBalance = new string[3,2];
string[,] rates = new string[3,3];

currencyBalance[0,0] = "USD";
currencyBalance[1,0] = "CNY";
currencyBalance[2,0] = "RUB";
currencyBalance[0,1] =   "10000.00";
currencyBalance[1,1] =  "200000.00";
currencyBalance[2,1] = "3000000.00";

rates[0,0] = "USD";
rates[1,0] = "USD";
rates[2,0] = "CNY";
rates[0,1] = "RUB";
rates[1,1] = "CNY";
rates[2,1] = "RUB";
rates[0,2] = "58.4568";
rates[1,2] = "6.7542";
rates[2,2] = "8.6600";

Console.WriteLine("Конвертер валют. Для проведения конвертации введите пожалуйста команду 'exchange'. Для просмотра списка всех доступных команд введите 'help'.");

while(true)
{
  userCommand = Console.ReadLine();
  switch(userCommand.ToLower())
  {
    case "exit":
      return;
    case "exchange":
      ExchangeCurrency();
      break;
    case "balance":
      PrintBalance();
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

void ExchangeCurrency()
{
  string availiableAmount = "";
  string currencyToBuy = ""; 
  string currencyToSell = "";
  double amountToSell = 0; 
  double amountToBuy = 0;
  double exchangeRate = 0;
 
  currencyToSell = InputString("Введите код валюты (например - USD), которую хотите продать: ");
  for (int i = 0; i < currencyBalance.GetLength(0); i++)
  {
    if (currencyBalance[i,0] == currencyToSell)
    {  
       availiableAmount = currencyBalance[i,1];
       Console.WriteLine($"Доступный остаток составляет {currencyToSell} {availiableAmount}");
       break;
    }
    if (i == currencyBalance.GetLength(0) - 1 && currencyBalance[i,0] != currencyToSell)
    {
      Console.WriteLine("Вы ввели неверный код валюты");
      return;
    }
  }
  
  Console.WriteLine($"Введите сумму {currencyToSell} для обмена: ");
  amountToSell = Convert.ToDouble(Console.ReadLine());
  if (Convert.ToDouble(availiableAmount) < amountToSell)
  {
     Console.WriteLine($"Cумма для обмена превышает доступный остаток");
     return;
  }  
  

  currencyToBuy = InputString("Введите код валюты, которую хотите купить: ");
  for (int i = 0; i < currencyBalance.GetLength(0); i++)
  {
    if (currencyBalance[i,0] == currencyToBuy)
       break;

    if (i == currencyBalance.GetLength(0) - 1 && currencyBalance[i,0] != currencyToBuy)
    {
      Console.WriteLine("Вы ввели неверный код валюты");
      return;
    }
  }
  
  for (int i = 0; i < rates.GetLength(0); i++)
  {
    if (rates[i,0] == currencyToSell && rates[i,1] == currencyToBuy)
    {
      exchangeRate = Convert.ToDouble(rates[i,2]);
      amountToBuy = amountToSell * exchangeRate;
      break;
    }
    else if (rates[i,0] == currencyToBuy && rates[i,1] == currencyToSell)
    {
      exchangeRate = Convert.ToDouble(rates[i,2]);
      amountToBuy = amountToSell * 1 / exchangeRate;
      break;
    }
  } 
     
  Console.WriteLine();
  Console.WriteLine("Проверьте параметры конвертации и подтвердите выполнение операции");
  Console.WriteLine($"Продажа. Валюта: {currencyToSell}. Сумма: {amountToSell}");
  Console.WriteLine($"Покупка. Валюта: {currencyToBuy}. Сумма: {amountToBuy}");
  Console.WriteLine($"Курс конвертации:{exchangeRate}.");
  
  Console.WriteLine("Подтверждаете проведение конвертации (y/n)?");
  string confirmExchange = Console.ReadLine();  

  if (confirmExchange == "y")
  {
    ChangeBalance(currencyToSell,-amountToSell,currencyBalance);
    ChangeBalance(currencyToBuy,amountToBuy,currencyBalance);
    Console.WriteLine("Конвертация проведена");
  } 
  else if (confirmExchange == "n")
  {
    Console.WriteLine("Операция отменена");
  }
}

void ChangeBalance(string currency, double amount, string [,] balance)
{
  for (int i = 0; i < balance.GetLength(0); i++)
  {
    if (balance[i,0] == currency)
    {
      balance[i,1] = Convert.ToString(Convert.ToDouble(balance[i,1]) + amount);
      break;
    }
  }
}

void PrintBalance()
{
  Console.WriteLine("Текущие остатки в разрезе валют.");
  for (int i = 0; i < currencyBalance.GetLength(0); i++)
  {
    Console.Write($"Остаток {currencyBalance[i,0]}:  {currencyBalance[i,1]}");     
    Console.WriteLine();
  }
 
}

void Help()
{
  Console.WriteLine("Список доступных команд:");
  Console.WriteLine("    help - получение списка команд;");
  Console.WriteLine("    exit - выход из программы;");
  Console.WriteLine("    exchange - обменять валюту;");
  Console.WriteLine("    balance - вывести на экран текущие остатки по всем валютам.");
}

string InputString(string output)
{
  Console.WriteLine(output);
  return  Console.ReadLine().ToUpper(); 
}

