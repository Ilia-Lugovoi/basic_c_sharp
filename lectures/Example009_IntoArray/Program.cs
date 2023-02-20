int FindMax(int arg1, int arg2, int arg3)
{
    int max = arg1;
    if(arg2 > max) max = arg2;
    if(arg3 > max) max = arg3;
    return max;
}

int[] array = {11, 21, 31, 41, 15, 61, 17, 18, 19};

int max = FindMax(
    FindMax(array[0], array[1], array[2]),
    FindMax(array[3], array[4], array[5]),
    FindMax(array[6], array[7], array[8])
);

Console.WriteLine(max);
