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
RoundArray(array);
Console.WriteLine($"Развернутый массив [{string.Join(", ", array)}]");

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

void RoundArray(int[] ishodn)
{
    int temp = 0;
    for (int i = 0; i < ishodn.Length / 2; i++)
    {
        temp = ishodn[i];
        ishodn[i] = ishodn[ishodn.Length -1 - i] ;
        ishodn[ishodn.Length -1 - i] = temp;
    }
}