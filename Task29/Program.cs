/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

Console.WriteLine("Введите ряд из 8 чисел");



int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = Convert.ToInt32(Console.ReadLine());
    }
    return result;

}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    foreach (int item in arr)
    {
        System.Console.Write(item + ", ");
    }
}

PrintArray(GetRandomArray(8));
System.Console.Write("]");