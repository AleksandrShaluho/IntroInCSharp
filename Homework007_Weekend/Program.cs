//программа принимает на вход цифру, обозначающую день недели и проверяет, является ли этот день выходным

Console.WriteLine("Введите номер дня недели: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());

if (DayNumber > 5) Console.WriteLine(DayNumber + "-> да");
else Console.WriteLine(DayNumber + "-> нет");
