//программа по заданному номеру четверти выводит диапазон возможных координат точек в этой четверти (x и y)

Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
int MinXY = 1;

if (quarter == 1) 
{
    Console.WriteLine($"В четверти {quarter} допустимы координаты x({MinXY},{Int32.MaxValue}); y({MinXY},{Int32.MaxValue})");
}
else if (quarter == 2)
{
    Console.WriteLine($"В четверти {quarter} допустимы координаты x({-MinXY},{-Int32.MaxValue}); y({MinXY},{Int32.MaxValue})");
}
else if (quarter == 3)
{
    Console.WriteLine($"В четверти {quarter} допустимы координаты x({-MinXY},{-Int32.MaxValue}); y({-MinXY},{-Int32.MaxValue})");
}
else if (quarter == 4)
{
    Console.WriteLine($"В четверти {quarter} допустимы координаты x({MinXY},{Int32.MaxValue}); y({-MinXY},{-Int32.MaxValue})");
}
else
{
    Console.WriteLine("Вы ввели неверное значение номера четверти. Нужно ввести число от 1 до 4");
}
