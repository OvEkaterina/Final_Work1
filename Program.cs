string[] array1 = { "Hello", "Yes", "22", ":-)", "1" };
int size = array1.Length;
string[] array2 = new string[size];
int j = 0;
for (int i = 0; i < size; i++)
{
    if (array1[i].Length <= 3)
    {
        array2[j] = array1[i];
        j++;
    }
}
Console.WriteLine("[{0}]", string.Join("  ", array1));
Console.WriteLine("[{0}]", string.Join("  ", array2));





