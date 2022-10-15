/* Задача 36
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях. */

// Метод считывания
int GetNumFromUser(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

// Метод проверки введенных данных
bool IsNumValid(int verifySize, int verifyMinValue, int verifyMaxValue)
{
    if (verifySize <= 0 || verifyMinValue > verifyMaxValue)
    {
        return false;
    }
    else
    {
        return true;
    }
}

// Метод генерации массива
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int arraySize = GetNumFromUser("Введите длину массива: ");
int arrayMinValue = GetNumFromUser("Введите минимальное значение элемента массива: ");
int arrayMaxValue = GetNumFromUser("Введите максимальное значение элемента массива: ");
bool isValid = IsNumValid(arraySize, arrayMinValue, arrayMaxValue);
if (isValid)
{
    int[] randomArray = CreateRandomArray(arraySize, arrayMinValue, arrayMaxValue);
    int sumEvenElements = 0;
    for (int i=1; i < arraySize; i+=2)
    {
        sumEvenElements += randomArray[i];
    }
    string result = string.Join(", ", randomArray);
    Console.WriteLine($"В массиве [{result}] сумма элементов, стоящих на нечётных позициях равна: {sumEvenElements}.");
}
else
{
    Console.WriteLine("Введены некорректные данные для формирования массива.");
}