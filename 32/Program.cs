/* Задача 32:**Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2] String.Join(", ", array)*/

Console.Clear();
int[] startArray = GetArray(6, -9, 10);
Console.WriteLine(String.Join(" ", startArray));
InversArray(startArray);
Console.WriteLine(String.Join(" ", startArray));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] InversArray(int[] array){// [1, -2, 3, -4, 5] ->[-1,2,-3,4,-5]
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}