//программа задает одномерный массив из 123 элементов и затем считает количество элементов, значения которых лежат в интервале от 10 до 99 вкючительно.

//основная часть программы
int[] numbers = new int[123];
int minIntervalValue = 10;
int maxIntervalValue = 99;
int numberOfElements = 0;

FillArray(numbers, 1, 150);

for(int i=0; i<numbers.Length; i++)
{
  if (numbers[i]>=minIntervalValue && numbers[i]<=maxIntervalValue)
    numberOfElements++;  
}
PrintArray(numbers);
Console.WriteLine($"Количество элементов в интервале от {minIntervalValue} до {maxIntervalValue} равно {numberOfElements}");


//часть программы, в которой описываются методы
void FillArray(int[] array, int minValue = -9, int maxValue = 10)
{
  for(int i=0; i<array.Length;i++)
  {
    array[i] = new Random().Next(minValue, maxValue);
  }
}

void PrintArray(int[] array)
{
  for(int i=0; i<array.Length;i++)
  {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}
