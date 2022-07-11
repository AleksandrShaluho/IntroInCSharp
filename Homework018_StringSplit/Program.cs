//Пользователь вводит с клавиатуры М чисел через запятую. Программа считает сколько чичисел больше нуля было введено

//основная часть программы
Console.WriteLine("Введите числа через запятую ");
string userString = Console.ReadLine();

string[] arrayOfStrings = new string[SplitString(userString).Length];
arrayOfStrings = SplitString(userString);
PrintArray(arrayOfStrings);

int countPositives = 0;

for (int i = 0; i < arrayOfStrings.Length; i++)
{
  if (Convert.ToInt32(arrayOfStrings[i]) > 0)
    countPositives++;
}

Console.WriteLine("Количество положительных чисел равно " + countPositives);

//часть программы, содержащая описания методов
string[] SplitString(string inputString, char delim = ',')
{
  string tempString = String.Empty;
  string[] splitedString;
  //1 - потому что строк всегда больше разделителей на 1
  int numOfStrings = 1;
  int pointer = 0;

  for (int i = 0; i < inputString.Length; i++)
  {
    if (inputString[i] == delim) 
      numOfStrings++;
  }

  splitedString = new string[numOfStrings];

  for(int i = 0; i < inputString.Length; i++)
  {
    if (inputString[i] != delim)
    {
      tempString += inputString[i];
      if (i != inputString.Length - 1)
      {
        continue;
      }
    }
    //на случай пустого места между запятыми - заполним нулем
    if (tempString == "")
      tempString = "0";
 
    splitedString[pointer] = tempString;
    tempString = String.Empty;
    pointer++;    
     
  }

  return splitedString;
}

void PrintArray(string[] array)
{
  for(int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
} 
     
