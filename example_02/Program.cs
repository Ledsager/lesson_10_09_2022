void PrintArray(int[,] matr)//вывод массива на экран
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)//заполнение массива случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);//[1; 10)
        }
    }
}

int[,] matrix = new int[4, 6];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

int[] arrayodnomernij = new int[matrix.GetLength(0) * matrix.GetLength(1)];
int i = 0;
foreach (var element in matrix)
{
    arrayodnomernij[i] = element;
    i++;
}


for (int j = 0; j < arrayodnomernij.Length - 1; j++)
{
    int maxPosition = j;
    for (int k = j + 1; k < arrayodnomernij.Length; k++)
        if (arrayodnomernij[k] > arrayodnomernij[maxPosition])
            maxPosition = k;
    int temporary = arrayodnomernij[j];
    arrayodnomernij[j] = arrayodnomernij[maxPosition];
    arrayodnomernij[maxPosition] = temporary;
}

foreach (var element in arrayodnomernij)
    Console.Write($"{element} ");

Console.WriteLine();
int schetchik = 1;
for (int k = 0; k < arrayodnomernij.Length - 1; k++)
{
    if (arrayodnomernij[k] == arrayodnomernij[k + 1])
        schetchik++;
    else
    {
        Console.WriteLine("элемент {0} встречается в матрице {1} ", arrayodnomernij[k], schetchik);
        schetchik = 1;
    }
}
Console.WriteLine("элемент {0} встречается в матрице {1} ", arrayodnomernij[arrayodnomernij.Length - 1], schetchik);


