//программа задает массив из 8 элементов и выводит их на экран

//основная часть
//метод FillArrayRandomly имеет необязательные аргументы, их можно не указывать пример ниже
//int [] randomArray = FillArrayRandomly(8);

int [] randomArray = FillArrayRandomly(8,-100,100);
PrintArray(randomArray);

//метод возвращает массив из N элементов, заполненный случайными целыми числами (по умолчанию - от 0 до 10)
//применение опциональных аргументов немного выходит за рамки задачи, но нам уже про них рассказывали.
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

//метод выводит на экран заполненный значениями массив, это void-метод - ничего не возвращает. 
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
