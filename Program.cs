// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 50);

        Console.Write($"{array[i, j]} ");

    }
    Console.WriteLine();
}

Console.WriteLine("Сортировка: ");
int[] row = new int[m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        row[j] = array[i, j];
    Sort(row);
    BackToOrig(true, i, row, array);
}
PrintArray(array);

static void Sort(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] < inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
}

static void BackToOrig(bool isRow, int count, int[] source, int[,] orig)
{
    for (int b = 0; b < source.Length; b++)
    {
        if (isRow)
            orig[count, b] = source[b];
        else
            orig[b, count] = source[b];
    }
}

static void PrintArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write(array[a, b] + " ");
        }
        Console.WriteLine();
    }
}



//  Задайте прямоугольный двумерный массив. Напишите программу, 
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 50);

        Console.Write($"{array[i, j]} ");

    }
    Console.WriteLine();
}

int sum = int.MaxValue;
int index = 0;
for (int i = 0; i < m; i++)
{
    int temp = 0;
    for (int j = 0; j < n; j++)
    {
        temp = temp + array[i, j];

    }
    if (temp < sum)
    {
        sum = temp;
        index = i;
    }
}
Console.WriteLine("Строка: " + index + " Сумма - " + sum);
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    Console.Write(array[index, i] + " ");
}



// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите m1: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int[,] array1 = new int[m1, n1];

for (int i = 0; i < m1; i++)
{
    for (int j = 0; j < n1; j++)
    {
        array1[i, j] = new Random().Next(0, 50);   
    }
}
Console.WriteLine("Введите m2: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int[,] array2 = new int[m2, n2];

for (int i = 0; i < m2; i++)
{
    for (int j = 0; j < n2; j++)
    {
        array2[i, j] = new Random().Next(0, 50);      
    }
}
Console.WriteLine("\nМатрица 1:");
Print(array1);
Console.WriteLine("\nМатрица 2:");
Print(array2);
Console.WriteLine("\nМатрица 3 = Матрица 1 * Матрица 2:");
int[,] arrayMult = Multiplication(array1, array2);
Print(arrayMult);

static int[,] Multiplication(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) != array2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] r = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                r[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return r;
}
static void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0} ", a[i, j]);
        }
        Console.WriteLine();
    }
}