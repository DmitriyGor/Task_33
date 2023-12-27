/*
Задача 33: 
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/

int[] GetArray (int size, int minValue, int maxValue)
// size = 12, minValue = -9, maxValue = 9
{
    int[] resultArray = new int [size];
    for (int i = 0; i < size; i++) // i < size = i < resultArray.Length
    {
        resultArray[i] = new Random ().Next(minValue, maxValue + 1);
    }
    return resultArray;
}
int[] array = GetArray (12, -9, 9);
// интерполяция $
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");

bool FindElement(int[] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
        {
            return true; // true - элемент найден
        }
        
    }
    return false; // false - элемент не найден
}
int numberForSearch = new Random().Next(10); // [0 - 10]
Console.WriteLine($"Рандомное число для поиска: {numberForSearch}");
    if(FindElement(array, numberForSearch)) // FindElement(arr, numberForSearch) == true
    {
        Console.WriteLine($"Число {numberForSearch}  в массиве ПРИСУТСТВУЕТ");
    }
    else // FindElement(arr, numberForSearch) == true
    {
        Console.WriteLine($"Число {numberForSearch}  в массиве ОТСУТСТВУЕТ");
    }