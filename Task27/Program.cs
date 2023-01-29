/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

static int GetCountNum(int numx)
{

    int count = 0;

    while (numx > 0)
    {
        count++;
        numx /= 10;
    }
    return count;
}

int countrs = GetCountNum(num);

static int GetSumCount(int count, int number)
{
    int result = 0;
    int temp = number;
    for (int i = 0; i <= count; i++) 
    {
        result = result + temp % 10;
        temp = temp / 10;
    }
    return result;
}
int sum = GetSumCount(countrs, num);
Console.WriteLine(sum);
