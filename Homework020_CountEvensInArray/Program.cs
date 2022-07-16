//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int size = InputInt("Задайте размер массива: ");
int[] positives = FillArrayRandomly(size, 100,1000);

PrintArray(positives);
Console.WriteLine("Количество четных чисел равно " + CountEvens(positives));

int CountEvens(int[] array)
{
  int evens = 0;

  for(int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
       evens++;
  }
  
  return evens;
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
    
    for (i = 0; i < array.Length; i++)
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
