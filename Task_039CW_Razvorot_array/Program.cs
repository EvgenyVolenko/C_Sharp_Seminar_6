// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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


Console.WriteLine($"Развернутый массив [{string.Join(", ", RoundArray(array))}]");


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

int[] RoundArray(int[] ishodn)
{
    int[] arrayR = new int[ishodn.Length];
    for (int i = 0; i < ishodn.Length; i++)
    {
        arrayR[ishodn.Length -1 - i] = ishodn[i];
    }
    return arrayR;
}