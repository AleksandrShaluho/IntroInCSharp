//Программа определяет название дня недели по его номеру (номер генерится случайно)

int NumberOfDay = new Random().Next(1,8);

if (NumberOfDay == 1) Console.WriteLine(NumberOfDay + "-> Понедельник");
if (NumberOfDay == 2) Console.WriteLine(NumberOfDay + "-> Вторник");
if (NumberOfDay == 3) Console.WriteLine(NumberOfDay + "-> Среда");
if (NumberOfDay == 4) Console.WriteLine(NumberOfDay + "-> Четверг");
if (NumberOfDay == 5) Console.WriteLine(NumberOfDay + "-> Пятница");
if (NumberOfDay == 6) Console.WriteLine(NumberOfDay + "-> Суббота");
if (NumberOfDay == 7) Console.WriteLine(NumberOfDay + "-> Воскресенье");
