//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали

int rows = InputInt("Введите количество строк ");
int columns = InputInt ("Введите количество столбцов ");
int[,] matrix = new int [rows, columns];

FillMatrix(matrix);
PrintMatrix(matrix);

SumDiagonalMatrix(matrix);

int InputInt(string output)
{
  Console.WriteLine(output);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

void PrintMatrix(int[,] array) 
{ 
  for(int i = 0; i < array.GetLength(0); i++) 
  { 
    for(int j = 0; j < array.GetLength(1); j++) 
    { 
//просто попробовал форматирование строки вывода по новому)
      Console.Write("{0, -4}", array[i, j]);
    } Console.WriteLine();
  }
  Console.WriteLine();
} 

void FillMatrix(int[,] array) 
{ 
  for(int i = 0; i < array.GetLength(0); i++) 
  { 
    for(int j = 0; j < array.GetLength(1); j++) 
    { 
      array [i, j] = new Random().Next(0,10);
    }
  }
}


void SumDiagonalMatrix(int[,] array) 
{ 
  int sum = 0;
  for(int i = 0; i < array.GetLength(0); i++) 
  { 
    for(int j = 0; j < array.GetLength(1); j++)
    {
      if (i == j)
        sum = sum + array [i, j];
    } 
  }
  Console.WriteLine(sum);
}
