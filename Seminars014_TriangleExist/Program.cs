//программа получает на вход три числа - длины сторон треугольника и проверяет может ли существовать треугольник (каждая сторона меньше сумм длин двух других сторон)

int FirstSideLength = InputInt("Введите длину первой стороны ");
int SecondSideLength = InputInt("Введите длину первой стороны ");
int ThirdSideLength = InputInt("Введите длину первой стороны ");

if (IsTriangleExist(FirstSideLength, SecondSideLength, ThirdSideLength))
   Console.WriteLine("Треугольник существует");
else
   Console.WriteLine("Треугольник не существует");


bool IsTriangleExist (int sideA, int sideB, int sideC)
{
if (sideA < (sideB + sideC) &&
    sideB < (sideA + sideC) &&
    sideC < (sideA + sideB))
   return true;

else return false;
}

int InputInt(string output)
{
  Console.WriteLine(output);
  return Convert.ToInt32(Console.ReadLine());
}
