//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько
//чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2  
//1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Введите числа через пробел: ");
string elements = Console.ReadLine(); //считывает элементы и заносит их в строки
int[] baseArray = GetArrayFromString(elements); //создает массив baseArray используя метод GetArrayFromString

int[] GetArrayFromString(string stringArray) //метод перевода элементов строки в элементы int
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int count=0;
foreach (int item in baseArray)
    {
        if (item>0) count++; // если элемент больше 0, то count+1 прибавляет
    }

Console.Write($"--> {count}");