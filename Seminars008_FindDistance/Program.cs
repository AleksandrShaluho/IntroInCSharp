//программа принимает на вход координаты 2х точек и находит расстояние между ними в двумерном пространстве

//получаем на вход 4 координаты - по две на каждую точку
Console.WriteLine("Введите координаты точки A по оси Х: ");
int firstPointX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки A по оси Y: ");
int firstPointY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B по оси Х: ");
int secondPointX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B по оси Y: ");
int secondPointY = Convert.ToInt32(Console.ReadLine());

//считаем величину отрезков (проекций точек) по осям Х и Y
int katetX = firstPointX - secondPointX;
int katetY = firstPointY - secondPointY;

//вычисляем расстояние по формуле Пифагора (гипотенуза в прямоугольном треугольнике образованном проекциями точек на оси)
double Distance = Math.Sqrt(katetX * katetX + katetY * katetY);

Console.WriteLine($"A({firstPointX},{firstPointY}); B({secondPointX},{secondPointY})-> {Distance}"); 




