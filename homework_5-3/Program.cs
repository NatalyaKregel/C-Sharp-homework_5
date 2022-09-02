/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.WriteLine("Введите размер массива N - "); 
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Исходный массив: "); 
int[]array = new int[N];
int index=0; 
int i = 0;
int raznica = 0;

while (index<N)
{
    array[index]=new Random().Next(0,101);
    Console.Write(array[index]+ ", ");
    index++;
}
Console.WriteLine();

int min = array[0];
int max = array[0];

for (i=0; i<N; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    else if (array[i] > max)
    {
        max = array[i];
    }
    raznica = max - min;
}
Console.WriteLine($"Минимальный элемент = {min}");
Console.WriteLine($"Максимальный элемент = {max}");
Console.WriteLine($"Разница между ними = {raznica}");