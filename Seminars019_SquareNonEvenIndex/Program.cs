//задайте двумерный массив. Надите элементы, у которых оба индекса нечётные,
//и замените эти элементы на их квадраты
int rows = InputInt("Введите количество строк ");
int columns = InputInt ("Введите количество столбцов ");
int[,] matrix = new int [rows, columns];

FillMatrix(matrix);
PrintMatrix(matrix);

ChangeNonevenInMatrix(matrix);
PrintMatrix(matrix);

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

void ChangeNonevenInMatrix(int[,] array) 
{ 
  for(int i = 1; i < array.GetLength(0); i+=2) 
  { 
    for(int j = 1; j < array.GetLength(1); j+=2) 
    { 
      array [i, j] = array[i,j]*array[i,j];
    }
  }
}