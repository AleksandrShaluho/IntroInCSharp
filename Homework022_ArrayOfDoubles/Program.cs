//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int size = InputInt("Введите размер массива: ");
int minValueInRange = -10;
int maxValueInRange = 10;
double[] arrayOfDoubles = FillArrayRandomly(size, minValueInRange, maxValueInRange);

PrintArray(arrayOfDoubles);

Console.WriteLine("Разница между максимальным и минимальным значением равна " + FindMaxMinDiff(arrayOfDoubles));

 
double FindMaxMinDiff(double[] array)
{
  double min = array[0];
  double max = array[0];

  for(int i = 0; i < array.Length; i++)
  {
    if (array[i] > max)
       max = array[i];
    if (array[i] < min)
       min = array[i];
  }
  
  return max-min;
}

double[] FillArrayRandomly(int numberOfElements, int minValue = 0,  int maxValue = 10)
{
    double[] array = new double[numberOfElements]; 
    int divider;
    double dividend;
    for (int i = 0; i < numberOfElements; i++)
    {
      divider = new Random().Next(1,maxValueInRange + 1);
      dividend = new Random().Next(minValueInRange,maxValueInRange + 1);
      array[i] = dividend/ divider;
    }
    return array;
}

void PrintArray(double[] array)
{
    int i = 0;
    
    //пустая строка чтобы визуально отделить вывод
    Console.WriteLine();   
    
    for (i= 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    //пустая строка чтобы визуально отделить вывод
    Console.WriteLine();   
}

int InputInt(string output)
{
  Console.WriteLine(output);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}
