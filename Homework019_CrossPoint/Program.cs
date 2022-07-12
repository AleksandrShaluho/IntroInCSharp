//программа вычисляет координаты точки пересечения двух прямых на плоскости

Console.WriteLine("Введите через запятую последовательно коэффициенты k1,b1,k2,b2: ");
string coeff = Console.ReadLine();
string[] lineCoeffs = new string[SplitString(coeff).Length];
lineCoeffs = SplitString(coeff);

int k1 = Convert.ToInt32(lineCoeffs[0]);
int b1 = Convert.ToInt32(lineCoeffs[1]);
int k2 = Convert.ToInt32(lineCoeffs[2]);
int b2 = Convert.ToInt32(lineCoeffs[3]);
double x;
double y;

if (LinesArrangement(k1,b1,k2,b2) == "intersect")
{
   x = CrossPoint('x', k1, b1, k2, b2);
   y = CrossPoint('y', k1, b1, k2, b2);
   Console.WriteLine($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} -> ({x};{y})");
}    
else 
{
   Console.WriteLine("Прямые либо параллельны, либо совпадают. Точку пересечения определить невозможно");
}   
  

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

string LinesArrangement(int k1, int b1, int k2, int b2)
//уравнение прямой y=kx+b, коэффициент при y по условию задачи всегда равен 1.
{
  string arrangement = String.Empty;
  
  if (k1==k2 && b1==b2)
     arrangement = "coincide";
  if (k1==k2 && b1!=b2) 
     arrangement = "parallel";
  else 
     arrangement = "intersect";
  
  return arrangement; 
}

double CrossPoint (char axis, double k1, int b1, int k2, int b2)
//уравнение прямой y=kx+b, коэффициент при y по условию задачи всегда равен 1.
//не знаю как вернуть сразу координаты сразу по двум осям, поэтому ввел аргумент axis
{
  double coordinate = 0;

  if (axis == 'x')
    coordinate = (b2-b1)/(k1-k2);
  else if (axis == 'y')
    coordinate =  k1*(b2-b1)/(k1-k2) + b1;
  
  return coordinate; 
}

  


