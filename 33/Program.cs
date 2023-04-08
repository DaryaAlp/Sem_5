/* **Задача 33:**Задайте массив.Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.
4; массив[6, 7, 19, 345, 3]->нет
3; массив[6, 7, 19, 345, 3]->да*/

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (FindElement(baseArray, n))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


int[] GetArrayFromString(string stringArray)//"1 2 3"
{
    string[] nums = stringArray.Split(" ");//"1 2 3" - > ["1", "2", "3"]
    int[] res = new int[nums.Length];//[0, 0, 0]

    for (int i = 0; i < nums.Length; i++)//[0, 0, 0] ["1", "2", "3"] - > [1 2 3]
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

bool FindElement(int[] array, int el)//[1,2,3] 3
{
    foreach (var item in array)//
    {
        if (el == item) // 3 == 3
            return true; 
    }
    return false;
}