//программа выводит случайное 3хзначное числоБ удаляет второй знак в числе и выводит результат

int Number = new Random().Next(100,1000);
int CuttedNumber = Number/100*10 + Number%10;

Console.WriteLine($"{Number}->{CuttedNumber}");

//альтернативно

//int FirstDigit = Number/100;
//int SecondDigit = Number%10;

//Console.WriteLine($"{Number}->{FirstDigit}{SecondDigit}");
