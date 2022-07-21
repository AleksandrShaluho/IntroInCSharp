//конвертер валют. У пользователя есть баланс в каждой из представленных валют. С помощью команд он может попросить сконвертировать одну валюту в другую. Курс конвертации просто описать в программе. Программа заканчивает свою работу в момент, когда решит пользователь

var currencyRates = new Dictionary<string, double>()
{
    ["USDRUB"] = 58.4568,
    ["USDCNY"] = 6.7542,
    ["CNYRUB"] = 8.6600

};

var currencyBalance = new Dictionary<string, double>()
{
    ["USD"] = 10000.00,
    ["CNY"] = 200000.00,
    ["RUB"] = 3000000.00

};

string userCommand = String.Empty;

Console.WriteLine("Конвертер валют. Для проведения конвертации введите пожалуйста команду 'exchange'. Для просмотра списка всех доступных команд введите 'help'.");

while (true)
{
    userCommand = Console.ReadLine();
    switch (userCommand.ToLower())
    {
        case "exit":
            return;
        case "exchange":
            ExchangeCurrency();
            break;
        case "balance":
            PrintBalance(currencyBalance);
            break;
        case "rates":
            PrintRates(currencyRates);
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
    string currencyToBuy = "";
    string currencyToSell = "";
    double amountToSell = 0;
    double amountToBuy = 0;

    PrintBalance(currencyBalance);
    PrintRates(currencyRates);

    currencyToSell = InputString("Введите код валюты (например - USD), которую хотите продать: ");
    if (!currencyBalance.ContainsKey(currencyToSell))
    {
        Console.WriteLine("Вы ввели неверный код валюты");
        return;
    }

    Console.WriteLine($"Введите сумму {currencyToSell} для обмена: ");
    amountToSell = Convert.ToDouble(Console.ReadLine());

    if (currencyBalance[currencyToSell] < amountToSell)
    {
        Console.WriteLine($"Cумма для обмена превышает доступный остаток");
        return;
    }

    currencyToBuy = InputString("Введите код валюты, которую хотите купить: ");

    if (!currencyBalance.ContainsKey(currencyToBuy))
    {
        Console.WriteLine("Вы ввели неверный код валюты");
        return;
    }

    string currencyPair = currencyToSell + currencyToBuy;
    string reversePair = currencyToBuy + currencyToSell;
    double exchangeRate = 0;
    if (currencyRates.ContainsKey(currencyPair))
    {
        exchangeRate = currencyRates[currencyPair];
        amountToBuy = Math.Round(amountToSell * exchangeRate, 2);
    }
    else if (currencyRates.ContainsKey(reversePair))
    {
        exchangeRate = currencyRates[reversePair];
        amountToBuy = Math.Round(amountToSell * Math.Round(1 / exchangeRate, 4), 2);
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
        currencyBalance[currencyToBuy] += amountToBuy;
        currencyBalance[currencyToSell] -= amountToSell;
        Console.WriteLine("Конвертация проведена");
    }
    else if (confirmExchange == "n")
    {
        Console.WriteLine("Операция отменена");
    }
}

void PrintBalance(Dictionary<string, double> currencies)
{
    Console.WriteLine("Доступные валюты");
    foreach (var currency in currencies)
    {
        Console.WriteLine($"Код - {currency.Key}, остаток -  {currency.Value}");
    }
    Console.WriteLine();
}

void PrintRates(Dictionary<string, double> rates)
{
    Console.WriteLine("Курсы валют");
    foreach (var rate in rates)
    {
        Console.WriteLine($"Валютная пара - {rate.Key}, курс -  {rate.Value}");
    }
    Console.WriteLine();
}

void Help()
{
    Console.WriteLine("Список доступных команд:");
    Console.WriteLine("    help - получение списка команд;");
    Console.WriteLine("    exit - выход из программы;");
    Console.WriteLine("    exchange - обменять валюту;");
    Console.WriteLine("    balance - вывести на экран текущие остатки по всем валютам.");
    Console.WriteLine("    rates - вывести на экран курсы валют");
}

string InputString(string output)
{
    Console.WriteLine();
    Console.WriteLine(output);
    return Console.ReadLine().ToUpper();
}

