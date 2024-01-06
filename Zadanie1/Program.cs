// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

int M = GetNumber("Введите число М: ");
int N = GetNumber("Введите число N: ");
listNumbers(M, N);

int GetNumber(string str)
{
    Console.WriteLine(str); //Задаем и выводим число;
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void listNumbers (int number1, int number2)
{
    if (number1 <= number2)
    {
        Console.Write(number1);
        listNumbers(number1 + 1, number2);
    }
}
