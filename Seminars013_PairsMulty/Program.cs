//программа задает массив, затем считает произведение пар элементов массива (первого и последнего и далее двигаясь к середине массива) и выводит результат в новый массив.

//основная часть программы
//задаем исходный массив 
int size = InputInt("Введите размер массива ");
int[] numbers = new int[size];

//мы еще не знаем размер нашего нового массива, но объявить его, то есть сказать программе, что такой есть - надо заранее, иначе объявление его в цикле выдаст ошибку
int[] multiplyPairs;

FillArray(numbers, 1, 100);
PrintArray(numbers);

//задаем размер нашего итогового массива в зависимости от того, четное или нечетное количество элементов в исходном массиве
if(numbers.Length%2 == 0)
{
  multiplyPairs = new int[numbers.Length/2];
}
else
{ 
  multiplyPairs = new int[numbers.Length/2+1];
//в последний элемент нового массива сразу записываем значение элемента исходного массива с таким же индексом. Потому что если массив нечетный то у числа из самой серединки массива нет пары, перемножать его ни на что не нужно, его надо просто перенести в новый массив в конец.
  multiplyPairs[multiplyPairs.Length -1] = numbers[numbers.Length/2];
}

//циклом перемножаем элементы исходного массива попарно и записываем в новый массив
for (int i = 0; i<numbers.Length/2;i++)
{
  multiplyPairs[i]=numbers[i]*numbers[numbers.Length-1 -i];
}

PrintArray(multiplyPairs);

//часть программы, в которой описываются методы
int InputInt(string output)
{
  Console.WriteLine(output);
  return Convert.ToInt32(Console.ReadLine());
}

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
