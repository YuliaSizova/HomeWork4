﻿/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Введите число A ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B ");
int numB = Convert.ToInt32(Console.ReadLine());

static int Exponentiation(int num1, int num2)

{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }

    return result;
}
int pow = Exponentiation(numA, numB);

System.Console.WriteLine(pow);
