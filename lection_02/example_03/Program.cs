// 

int [] array = {0, 24, -10, 131, 32, 95, -1, 0, 306};
int n = array.Length;
int find = 0;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // прервывает цикл
    }
    index++;

}

