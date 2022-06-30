int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}

int a1 = 23;
int b1 = 9;
int c1 = 11;

int a2 = 19;
int b2 = 33;
int c2 = 111;

int a3 = 22;
int b3 = 33;
int c3 = 1;

int max = Max(Max(a1,b1,c1),Max(a2,b2,c2), Max(a3,b3,c3));
Console.WriteLine("Максимальное значение = " + max);
