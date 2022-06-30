//Программа получает на вход число и проверяет, является ли оно четным

int Number = new Random().Next(10001);

if (Number%2==0) Console.WriteLine(Number + " ->да");
else Console.WriteLine(Number + " ->нет");

//альтернативно

//string Even = "нет";
//if (Number%2==0) Even = "да";
//Console.WriteLine(Number + "->" + Even);
