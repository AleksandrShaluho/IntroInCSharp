//программа принимает на вход координаты двух чисел в 3хмерном пространстве и находит расстояние между ними
//решаем задачу исходя из формулы геометрии: квадрат диагонали параллепипеда равне сумме квадратов его измерений.

Console.WriteLine("Введите координаты точки A - по оси Х: ");
int PointA_X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки A - по оси Y: ");
int PointA_Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки A - по оси Z: ");
int PointA_Z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B - по оси Х: ");
int PointB_X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B - по оси Y: ");
int PointB_Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B - по оси Z: ");
int PointB_Z = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Pow(PointB_X-PointA_X,2)+
                            Pow(PointB_Y-PointA_Y,2)+
                            Pow(PointB_Z-PointA_Z,2));
Console.WriteLine($"A({PointA_X},{PointA_Y},{PointA_Z});B({PointB_X},{PointB_Y},{PointB_Z}) -> {distance}");


//возведение в квадрат используем несколько раз. Это повод попробовать написать свою функцию для вычисления возведения в степень. Тип данных возьмем double.
double Pow(double number, int powNumber)
{
    int count = 1;
    double pow = 1;    
    while (count <= powNumber)
    {
        pow*=number;
        count++;
    }
    Console.WriteLine(pow); 
    return pow;
}
