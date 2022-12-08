// Задача 45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

Console.Clear();
int digit;
const int LEFTRANGE = -100;
const int RIGHTRANGE = 100;

Console.Write("Введите длинну массива: ");

while (true)
{
    if (int.TryParse(Console.ReadLine(), out digit)) break;
    else Console.Write("Ну просил же ЧИСЛО: ");
}

int[] array = FillArray(digit, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"Массив после заполнения [{string.Join(", ", array)}]");

Console.WriteLine($"Копия массива [{string.Join(", ", CopyArray(array))}]");

int[] CopyArray(int[] arr)
{
    int[] arrC = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arrC[i] = arr[i];
    }
    return arrC;
}

int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}