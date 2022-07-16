//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int size = InputInt("Задайте размер массива: ");
int minValueInRange = -100;
int maxValueInRange = 100;
int[] randomNumbers = FillArrayRandomly(size, minValueInRange, maxValueInRange);

PrintArray(randomNumbers);
Console.WriteLine("Сумма элементов с нечетным индексом равна " + SumElemWithNonevenIndex(randomNumbers));

int SumElemWithNonevenIndex(int[] array)
{
  int sum = 0;
  
  for(int i = 0; i< array.Length; i++)
  {
    if (i % 2 == 1)
       sum+=array[i];
  }
  
  return sum;
}

int[] FillArrayRandomly(int numberOfElements, int minValue = 0, int maxValue = 10)
{
    int[] array = new int[numberOfElements]; 
    for (i = 0; i < numberOfElements; i++)
    {
        array[i] = new Random().Next(minValue,maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
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
