Random random = new Random();

void SluchayniyMassiv(int[] massiv)
{
    int i = 0;
    while (i < massiv.Length)
    {
        massiv[i] = random.Next(10);
        Console.Write(massiv[i] + " ");
        i++;
    }
}
int[] array = new int[3];
SluchayniyMassiv(array);

