int FindMax(int arg1, int arg2, int arg3)
{
    int max = arg1;
    if(arg2 > max) max = arg2;
    if(arg3 > max) max = arg3;
    return max;
}

int a1 = 13;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 333;

int max1 = FindMax(a1, b1, c1);
int max2 = FindMax(a2, b2, c2);
int max3 = FindMax(a3, b3, c3);
int max = FindMax(max1, max2, max3);


Console.WriteLine(max);
