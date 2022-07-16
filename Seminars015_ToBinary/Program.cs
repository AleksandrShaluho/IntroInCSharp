//напишите программу, которая будет преобразовывать десятичное число в двоичное

int number = InputInt("Введите целое число ");
Console.WriteLine("{0} -> {1}", number, DecimalToBinary(number));


string DecimalToBinary (int dec)
{
  string binary = "";
  while (dec>0)
  {
    binary = dec%2 + binary;
    dec=dec/2;
  }
  return binary;
}

int InputInt(string output)
{
  Console.WriteLine(output);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}
