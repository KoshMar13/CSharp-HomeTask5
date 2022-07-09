// 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] NewArrayRnd(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        if (i == 0)
            Console.Write("[");
        if (i < len - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i] + "]");
    }
}

double ArrMaxMinDif(double[] array)
{
    // double min = array.Min();
    // double max = array.Max();  решение встроенными методами
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++) //решение вручную
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
    }
    double result = max - min;
    return result;
}

double[] arr = NewArrayRnd(5, -100, 101);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine(ArrMaxMinDif(arr));
