// Домашняя работа. Семинар 4 функции.
// Задача 1(25). Напишите цикл, который принимает на вход два числа (А и В) и возводит в натуральную степень В.
/*
int ExponNum(int a, int b)
{
    int result = 1;
    for(int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}
Console.Write("Input a first number: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int second = Convert.ToInt32(Console.ReadLine());

int result = ExponNum(first, second);
Console.WriteLine(result);
*/


// Задача 2(27). Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
/*
int NumSum(int num)
{
    int  sum = 0;
    while(num > 0)
    {
        int num1 = num % 10;
        num = num / 10;
        sum = sum + num1;
    }
    return sum;
}
Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = NumSum(a);
Console.WriteLine($"Sum of numbers of number {a} is {result}");
*/




// Задача 3(29). Напишите программу, которая задает массив из 8 элементов и выводит их на экран.

/*
int[] CreateEightArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Input eight numbers of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
} 
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.Write("Input a number elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateEightArray(length, min, max);
ShowArray(myArray);
*/