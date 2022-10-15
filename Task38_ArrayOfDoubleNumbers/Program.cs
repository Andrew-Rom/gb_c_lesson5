/* Задача 38
Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
Пример:
[3 7 22 2 78] -> 76 */

// Метод получения массива при вводе
double[] GetArrayFromString(string stringArray)
{
    string[] strArray = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[] numArray = new double[strArray.Length];
    for (int i = 0; i < strArray.Length; i++)
    {
        numArray[i] = double.Parse(strArray[i]);
    }
    return numArray;
}

Console.Write("Задайте массив вещественных чисел (через пробел): ");
string getArray = Console.ReadLine();
double[] inputArray = GetArrayFromString(getArray);
double minValue = inputArray[0];
double maxValue = inputArray[0];
for (int i=1; i<inputArray.Length; i++)
{
    if (minValue > inputArray[i])
    {
        minValue = inputArray[i];
    }
    else if (maxValue < inputArray[i])
    {
        maxValue = inputArray[i];
    }
}
string printArray = string.Join(" ", inputArray);
Console.WriteLine($"Разница между максимальным ({maxValue}) и минимальным ({minValue}) элементами массива [{printArray}] равна: {maxValue-minValue}.");
