// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

int M = GetNumber();
int N = GetNumb();

int GetNumber()
{
    Console.WriteLine("Введите число M: "); //Задаем и выводим число;
    int number1 = Convert.ToInt32(Console.ReadLine());
    return number1;
}

int GetNumb()
{
    Console.WriteLine("Введите число N: "); //Задаем и выводим число;
    int number2 = Convert.ToInt32(Console.ReadLine());
    return number2;
}

int Acc = FindAcc(M,N);

int FindAcc(int number1, int number2)
{
    if (number1 == 0)
    {
        return number2 + 1;
    }
    else  if ((number1 >= 0) && (N == 0))
    {
     return FindAcc(number1 - 1, 1);
    }
    else return FindAcc(number1 - 1, FindAcc(number1, number2 - 1));  
}
Console.WriteLine(Acc);