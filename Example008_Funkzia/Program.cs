int a1 = 12;
int b1 = 32;
int c1 = 88;
int a2 = 21;
int b2 = 38;
int c2 = 15;
int a3 = 42;
int b3 = 68;
int c3 = 37;

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result)result = arg2;
    if(arg3 > result)result = arg3;
    return result;

}

int arg1 = Max(a1, b1, c1);
int arg2 = Max(a2, b2, c2);
int arg3 = Max(a3, b3, c3);

int max = Max(arg1, arg2, arg3);
Console.WriteLine(max);

