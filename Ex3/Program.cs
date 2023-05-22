// Задайте массив. Напишите программу, которая определяет, присутствует 
// ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// использовать преобразование чисел по модулю (интересует только значение числа)

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        //Console.Write($"{res[i]} ");
    }
    return res;
}

void CheckNumArr(int[] arr, int num)
{
    bool check = false;
    num = Math.Abs(num);
    foreach (int el in arr)
    {
        if (el == num)
        {
            Console.WriteLine($"{num}; массив [ {String.Join(" ", arr)} ] -> да");
            check = true;
            break;
        }
    }
    if (check == false)
    {
        Console.WriteLine($"{num}; массив [ {String.Join(" ", arr)} ] -> нет");
    }
}

int[] array = GetArray(10, -10, 10);
Console.WriteLine();
CheckNumArr(array, -4);
