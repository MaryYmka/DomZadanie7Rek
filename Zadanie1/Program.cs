// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

int N = GetNumber();
int M = GetNumb();
listNumber(N, M);

int GetNumber()
{
    Console.WriteLine("Введите число N: "); //Задаем и выводим число;
    int number1 = Convert.ToInt32(Console.ReadLine());
    return number1;
}

int GetNumb()
{
    Console.WriteLine("Введите число M: "); //Задаем и выводим число;
    int number2 = Convert.ToInt32(Console.ReadLine());
    return number2;
}

void listNumber (int number1, int number2, int start =0)
{
    start = number1;
    if (start <= M)
    {
        Console.WriteLine(start);
        listNumber(number2, start+1);
    }
  
}
