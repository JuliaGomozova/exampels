int[] array = { 1, 21, 3, 14, 5, 61, 3, 17, 8, 9};

int find = 3;
int n = array.Length;

int index = 0;

while (index < n)
{
    if (array[index] == find) 
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}