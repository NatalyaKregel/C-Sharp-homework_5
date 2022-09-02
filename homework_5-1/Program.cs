/* //Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.WriteLine("Введите размер массива N - "); 
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Исходный массив: "); 
int[]array = new int[N];
int index = 0;
while (index<N)
{
    array[index]=new Random().Next(100,201);
    Console.Write(array[index]+ ", ");
    index++;
}
  
    int j=0;
    int count = 0;

    for (j=0; j < N; j++)
    if (array[j] % 2 == 0)
    {
        count++;
    }
    Console.WriteLine();
    Console.WriteLine($"Наш массив состоит из {N} чисел, {count} из них являются четными");
