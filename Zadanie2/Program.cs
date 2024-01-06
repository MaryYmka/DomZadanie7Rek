// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

int N = GetNumber("Введите число N: ");
int M = GetNumber("Введите число M: ");

int GetNumber(string str)
{
    Console.WriteLine(str); //Задаем и выводим число;
    int number1 = Convert.ToInt32(Console.ReadLine());
    return number1;
}

int FindAcc(int number1, int number2)
{
    if (number1 == 0)
    {
        return number2 + 1;
    }
    else  if ((number1 >= 0) && (number2 == 0))
    {
     return FindAcc(number1 - 1, 1);
    }
    else return FindAcc(number1- 1, FindAcc(number1, number2 - 1));  
    
 }
Console.Write($"Функция Аккермана = {FindAcc(N ,M)} ");