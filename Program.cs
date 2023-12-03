// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементом массива.

int i = 0;
double[] array = new double[5];
double min = 100000;
double max = 0;
double difference = 0;
for (i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(new Random().NextDouble() * new Random().Next(1001), 2);
    {
        if (array[i] < min) min = array[i];
    }
    {
        if (array[i] > max) max = array[i];
    }

    difference = max - min;

}
Console.WriteLine($"[ {string.Join("; ", array)} ] >= {difference}");
