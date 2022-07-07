// 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] NewArrayRnd(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
            Console.Write("[");
        if (i < array.Length - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i] + "]");
    }
}

int[] MultiCouples(int[] array)
{
    int[] answer = new int[array.Length / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        answer[i] = array[i] * array[array.Length - 1 - i];
    }
    return answer;
}

int[] arr = NewArrayRnd(5, 0, 11);
PrintArray(arr);
Console.WriteLine();
PrintArray(MultiCouples(arr));
