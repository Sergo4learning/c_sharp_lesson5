// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Random rnd = new Random();
int[] get_array(int num)
{
    int[] coord = new int[num];    
    for (int i = 1; i<=num; i++)
    {
        coord[i-1] = rnd.Next(100, 1000);
    }    
    return coord;
}
void output_array(int[] arr, int num)
{
    Console.Write("[");
    for (int i=1; i<num; i++)
    {
        Console.Write(arr[i-1]+", ");
    }
    Console.WriteLine(arr[num-1]+"]");
}
int num_of_even_numbers(int[] arr, int num)
{
    int kol = 0;
    for (int i=1; i<= num; i++)
    {
        if (arr[i-1]%2==0)
        {
            kol=kol+1;
        }
    }
    return kol;
}
Console.Write("Введите размерность массива: ");
int arr_dim = Convert.ToInt32(Console.ReadLine());
int[] array = get_array(arr_dim);
output_array(array, arr_dim);
Console.WriteLine(num_of_even_numbers(array, arr_dim));