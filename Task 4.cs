// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16




Console.WriteLine("Введите число А");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа А");
int numB = Convert.ToInt32(Console.ReadLine());
int result = numA;

void Exponent(int num)
{
    for (int i = 1; i < numB; i++)
    {
        result = result * numA;
    }
}
Exponent(numA);
Console.WriteLine($"{numA},{numB} -> {result}");




//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12




Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
void SumAllNumbers(int num)
{
    for (int i = 0; num > 0; i++)
    {
        int A = num % 10;
        sum = sum + A;
        num = num / 10;
    }
}
SumAllNumbers(num);
Console.WriteLine($"{num} -> {sum}");




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]




int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return myArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Полученный массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int lenght = 8;
int min = -99;
int max = 99;

int[] newArray = CreateRandomArray(lenght, min, max);
ShowArray(newArray);