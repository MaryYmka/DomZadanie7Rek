// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

//Заполнение массива
static iint[] GetArray(int number)
{
    //Определение кол-ва цифр в числе
    int Count = CountDigits(number);
    // Создание массива из цифр
    int [] array = new int[Count];
    for (int i = Count -1; i >= 0; i--)
    {
        array[i] = number % 10;
        number /= 10;
    }
    return array;
}
    // Создание массива из цифр
    int [] array = new int[N];
