// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] array = new int [20];
int firstNum = 0;
int secondNum = 0;
for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0) 
    {
        firstNum += 1;
    }
    else 
    {
        secondNum += 1;
    }
}
for (int i = 0; i < array.Length; i++) 
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.WriteLine($"Четные числа = {firstNum}");
Console.WriteLine($"Нечетные числа = {secondNum}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int [20];
int result = 0;
for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(0, 100);
    Console.Write ($"{array[i]} ");
}
Console.WriteLine();
for (int j = 1; j < array.Length; j = j + 2) 
{
    result += array[j];
}
Console.WriteLine();
Console.WriteLine($"Сумма всех нечетных чисел {result} ");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] array = new double [20];

double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().NextDouble(); 
    Console.Write($"{array[i]} ");
    if (array[i] > max) max = array[i];
    if (min > array[i]) min = array[i];
}
double result = max - min;

Console.WriteLine();
Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементами массива равна {result}");