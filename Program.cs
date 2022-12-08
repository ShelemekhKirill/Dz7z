/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

/* Console.WriteLine("Введите количество строк  ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
 */



/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
i = 5; j = 2 -> такого числа в массиве нет
i = 1; j = 1 -> 9 */

/* int rows = ReadInt("Введите индекс строки: ");
int colums = ReadInt("Введите индекс столбца: ");
int[,] numbers = new int[6, 8];
FillArray2D(numbers);
PrintArray2D(numbers);
if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");
void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} */



/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

/* Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Среднее арифметическое каждого столбца:");


for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{ sum / arr.GetLength(0)}; ");    
}
Console.ReadLine(); */





//                                         Исправленная задача 25 из 4 урока

 /* Напишите цикл, который принимает на вход два числа (A и B) 
 и возводит число A в натуральную степень B. 
 (Задачи, решенные через Math.Pow, будут отправлены на переделку, 
 так как задача стоит в том, чтобы написать цикл)
3, 5 -> 243 (3⁵)
2, 4 -> 16 */


/* Console.Write("Видите число:  ");         
int a = int.Parse(Console.ReadLine()!);     
Console.Write("Видите степень:  ");            
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{a} в степени {b} = {Pow(a,b)}");

int Pow(int num, int rank)
{
    if(rank==0) return 1;

    int result = num;
    for (int i = 2; i <= rank; i++)
    {
        result *= num;
    }
    return result;
}*/



//                                  Исправленная задача 37 из 5 урока

 /*  Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3   [6 7 3 6] -> 36 21 */

/*Console.WriteLine("Введите размер массива: ");
int m = int.Parse(Console.ReadLine()!);
int[] array = new int[m];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 20);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int q = array.Length - 1;
for (int i = 0; i < (array.Length + 1) / 2; i++)
{
    Console.Write(array[i] * array[q] + " ");
    q--;
}*/
