//программа заполняет двухмерный массив, каждый элемент сумма индексов.

int rows = InputInt("Введите количество строк ");
int columns = InputInt ("Введите количество столбцов ");
int[,] matrix = new int [rows, columns];

FillMatrix(matrix);
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
} 

void FillMatrix(int[,] array) 
{ 
  for(int i = 0; i < array.GetLength(0); i++) 
  { 
    for(int j = 0; j < array.GetLength(1); j++) 
    { 
      array [i, j] = i + j;
    }
  }
}