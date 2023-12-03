// : Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

int size = 10;
int count = 0;
int i = 0;
int[] array = new int[size];
for (i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 200); 
    if(array[i] % 2 == 0)
    count++;
}

Console.WriteLine($"[ {string.Join("; ", array)} ] >= {count}");

