int[] array = { 11, 21, 31, 41, 51, 61, 11, 81, 61 };
int n = array.Length; // возвращает длину (количество элементов) массива array.
int find = 61;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // прервать цикл если значение true
    }
    // index = index + 1;
    index++;
}
