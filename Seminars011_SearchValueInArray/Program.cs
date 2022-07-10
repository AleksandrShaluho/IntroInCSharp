//программа задает массив и определяет, есть ли в массиве число, указанное пользователем

//основная часть программы
int size = InputInt("Введите размер массива: ");
int[] numbers = new int[size];
//для варианта с логическим флагом без return нам нужна булева переменная
//bool isTrue;

//вариант с return, когда просто выходим из программы если нашли число
//сначала заполняем и выводим массив, а потом спрашиваем число. Так удобнее для тестирования, чтобы видеть какие числа вообще есть в массиве
FillArray(numbers);
PrintArray(numbers);

int desiredNumber = InputInt("Введите искомое число: ");

//циклом ищем в массиве число. Нам важен сам факт, есть такое число или нет. Количество таких же чисел либо их позиция в массиве - не инетерсуют. Если нашли, выходим из программы, прерывая цикл
for(int i=0;i<numbers.Length;i++)
{
  if (numbers[i]==desiredNumber)
  {
    Console.WriteLine($"Число {desiredNumber} есть в массиве");
    return;
  }
}
Console.WriteLine($"Числа {desiredNumber} нет в массиве");  

//вариант с использованием логического флага, без return, позволяет продолжить программу после того как нашли число (если нужно еще что-то сделать в программе)
/*for(int i=0;i<numbers.Length;i++)
{
  if (numbers[i]==desiredNumber)
  {  
    isTrue = true;
    break;
  }
}
if (isTrue)
  Console.WriteLine($"Число {desiredNumber} есть в массиве");
else
  Console.WriteLine($"Числа {desiredNumber} нет в массиве"); 
*/

//часть программы, в которой описываются методы
int InputInt(string output)
{
  Console.WriteLine(output);
  return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
  for(int i=0; i<array.Length;i++)
  {
    array[i] = new Random().Next(-9,10);
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
