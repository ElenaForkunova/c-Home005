/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

//инициируем массив:
int[] array = new int [new Random().Next(5,10)];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(99, 1000);
    Console.Write(array[i] + " ");
}

int Count(int[] array)
{
    int count = 0;
    for (int i =0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine($"количество чётных чисел в массиве = {Count(array)}");
Console.WriteLine($" ");

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] array1 = new int [new Random().Next(4,11)];

for (int i = 0; i < array1.Length; i++)
{
    array1[i] = new Random().Next(-10, 10);
    Console.Write(array1[i] + " ");
}
int sum = 0;
for (int i = 1; i < array1.Length; i++)
    {
        if(i%2!=0)
        sum +=array1[i];
    }
Console.WriteLine("сумма элементов cтоящих на нечётных позициях " + sum );
Console.WriteLine($" ");

/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double[] array2 = new double[10];
Random rand = new Random();
for (int i = 0; i < array2.Length; i++)
{
    array2[i] = rand.NextDouble() * 100;     
    /*100 - rand.Next(100) + rand.NextDouble();*/
    Console.WriteLine("{0,6:F2}", array2[i] + " ");
}
var max = array2[0];
var min = array2[0];
    for (int i = 1; i < 10; i++)
        {
            if (array2[i] < min) min = array2[i];
            if (array2[i] > max) max = array2[i];
        }

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
Console.WriteLine($" ");