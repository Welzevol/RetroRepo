using System.Collections;

int size = 10;
int i = 0;
int count = 0;
int[] array = new int[size];
for (i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101);

    if (array[i] >= 20 && array[i] <= 90)

        count++;
}

Console.WriteLine($"[ {string.Join("; ", array)} ] >= {count}");
