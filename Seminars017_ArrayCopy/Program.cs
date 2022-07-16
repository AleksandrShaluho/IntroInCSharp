//напишите программу, которая будет копировать массив поэлементно

int[] originArray = FillArrayRandomly(10);
int[] arrayCopy = new int[originArray.Length];

PrintArray(originArray);

for(int i = 0; i < originArray.Length; i++)
{
  arrayCopy[i] = originArray[i];
}

PrintArray(arrayCopy);


int[] FillArrayRandomly(int numberOfElements, int minValue = 0, int maxValue = 10)
{
    int[] array = new int[numberOfElements]; 
    int i =0;
    for (i = 0; i < numberOfElements; i++)
    {
        array[i] = new Random().Next(minValue,maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
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


