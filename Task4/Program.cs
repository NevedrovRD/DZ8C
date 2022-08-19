// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int n = 2;
int m = 2;
int l = 2;
int[,,] matrix = new int[2, 2, 2] { { { 12, 13 }, { 15, 16 } }, { { 22, 23 }, { 25, 26 } } };
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        for (int k = 0; k < l; k++)
            Console.Write(matrix[i, j, k] + "" + (i, j, k) + " ");
    Console.WriteLine();
    Console.WriteLine();
}