// Примитивная функция 

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a = 10;
int b  = 0;
int c = 13;
int d = 92;
int e = -38;
int f = 3;
int g = 117;
int h = 455;
int j = -2;

// int max1 = Max(a, b, c);
// int max2 = Max(d, e, f);
// int max3 = Max(g, h, j);
int max = Max(Max(a, b, c), Max(d, e, f), Max(g, h, j));



Console.WriteLine(max);
