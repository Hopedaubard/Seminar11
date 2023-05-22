// Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


int[] GetArray(int size, int minValye, int maxValye)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValye, maxValye + 1);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

void NegativeNumArr(int[] userArray)
{
    int arrSize = userArray.Length;
    for (int el = 0; el < arrSize; el++)
    {
        userArray[el] *= -1;
        Console.Write($"{userArray[el]} ");
    }
}

int[] array = GetArray(4, -9, 9);
Console.WriteLine();
NegativeNumArr(array);
