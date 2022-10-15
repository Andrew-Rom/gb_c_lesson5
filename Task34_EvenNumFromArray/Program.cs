/* Задача 34
Задайте массив, заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве. */

// Метод считывания
int GetNumFromUser(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

// Метод проверки введенных данных
bool IsNumValid(int verifyValue)
{
    if (verifyValue <= 0)
    {
        return false;
    }
    else
    {
        return true;
    }
}

// Метод генерации массива
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int arraySize = GetNumFromUser("Введите длину генерируемого массива: ");
bool isValid = IsNumValid(arraySize);
if (isValid)
{
    int[] randomArray = CreateRandomArray(arraySize);
    int counterEvenNumbers = 0;
    for (int i=0; i < arraySize; i++)
    {
        if (randomArray[i] % 2 == 0)
        {
            counterEvenNumbers += 1;
        }
    }
    string result = string.Join(", ", randomArray);
    Console.WriteLine($"В массиве [{result}] количество четных числел: {counterEvenNumbers}.");
}
else
{
    Console.WriteLine("Введена некорректная длина массива.");
}
