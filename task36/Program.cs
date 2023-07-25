// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Random rnd = new Random();
int[] get_array(int num)
{
    int[] coord = new int[num];    
    for (int i = 1; i<=num; i++)
    {
        coord[i-1] = rnd.Next(-100, 100);
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
int summ_of_even_nums(int[] arr, int num)
{
    int summ = 0;
    for (int i=1; i<= num-1; i=i+2)
    {
        summ=summ+arr[i];
    }
    return summ;
}
Console.Write("Введите размерность массива: ");
int arr_dim = Convert.ToInt32(Console.ReadLine());
int[] array = get_array(arr_dim);
output_array(array, arr_dim);
Console.WriteLine(summ_of_even_nums(array, arr_dim));