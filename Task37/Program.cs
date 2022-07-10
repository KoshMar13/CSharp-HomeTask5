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

// int[] MultiCouplesEven(int[] array) //Да, я понимаю, что пошёл сложным путём. Простой путь см. строки 65 и далее.
// {
//     int len = array.Length;

//     int[] answer = new int[len / 2];
//     for (int i = 0; i < len / 2; i++)
//     {
//         answer[i] = array[i] * array[len - 1 - i];
//     }

//     return answer;
// }

// int[] MultiCouplesOdd(int[] array)
// {
//     int len = array.Length;
//     int[] answer = new int[len / 2 + 1];
//     for (int i = 0; i < len / 2; i++)
//     {
//         answer[i] = array[i] * array[len - 1 - i];
//     }
//     answer[len / 2] = array[len / 2];
//     return answer;
// }

// int[] arr = NewArrayRnd(5, 0, 11);
// PrintArray(arr);
// Console.WriteLine();
// if (arr.Length % 2 == 0)
//     PrintArray(MultiCouplesEven(arr));
// else
//     PrintArray(MultiCouplesOdd(arr));

int[] MultiCouples(int[] array)
{
    int res = len % 2 == 0 ? int[] answer = new int[len / 2] : int[] answer = new int[len / 2 + 1];

    for (int i = 0; i < len / 2; i++)
    {
        answer[i] = array[i] * array[len - 1 - i];
    }
    return answer;
}
int[] arr = NewArrayRnd(5, 0, 11);
PrintArray(arr);
Console.WriteLine();
PrintArray(MultiCouples(arr));
