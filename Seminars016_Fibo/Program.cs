//программа выводит первые N чисел Фибоначчи
//числа Фибоначчи: каждое следующее равно сумме двух предыдущих. Ноль равен единице, 1 равна единице, потом стандартно.

int number = 3;
string fibo = String.Empty;
for(int i = 0; i <= number; i++)
{
  if (i == 0)
  {  fibo = "0 ";
    continue;
  }
  if (i == 1)
  { 
    fibo = fibo + "1";
    continue;
  }
  fibo = fibo + " " + ((i-1)+(i-2));
  
}
Console.WriteLine(fibo);

