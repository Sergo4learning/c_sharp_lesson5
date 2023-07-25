// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

float[] get_array(int num)
{
    float[] coord = new float[num];    
    for (int i = 1; i<=num; i++)
    {
        Console.Write("Введите "+i+" Элемент массива: ");
        coord[i-1] = (float)Convert.ToDouble(Console.ReadLine());
    }    
    return coord;
}
float [] get_min_max_etc(float[] arr, int num)
{
    float [] all = new float[3];
    all[0]=arr[0];
    all[1]=arr[0];
    for (int i=1; i< num;i++)
    {
        if (arr[i-1]<all[0])
        {
            all[0]=arr[i-1];
        }
        if (arr[i-1]>all[1])
        {
            all[1]=arr[i-1];
        }
    }
    all[2]=all[1]-all[0];
    return all;
}
void output_array(float[] arr, int num)
{
    Console.Write("[");
    for (int i=1; i<num; i++)
    {
        Console.Write(arr[i-1]+", ");
    }
    Console.WriteLine(arr[num-1]+"]");
}
Console.Write("Введите размерность массива: ");
int arr_dim = Convert.ToInt32(Console.ReadLine());
float[] array = get_array(arr_dim);
float[] rez = get_min_max_etc(array, arr_dim);
output_array(array, arr_dim);
Console.WriteLine(rez[1]+" - "+rez[0]+" = "+rez[2]);