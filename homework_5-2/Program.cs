/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Write("Введите размер массива N - "); 
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Исходный массив: "); 
int[]array = new int[N];
int index = 0;
int sum = 0;
for (index=0; index<N; index++)
{
    array[index]=new Random().Next(0,11);
    Console.Write(array[index]+ ", ");
}
Console.WriteLine();
sumNumbers(array);
Console.WriteLine($"Сумма элементов на нечетных позициях - {sum}");

    int sumNumbers (int[]array)
    {
        for (int j = 1; j < N; j++)
        {
            if (j % 2 != 0)
            sum = sum + array[j]; 
        }
        return (sum);
    } 
    
    