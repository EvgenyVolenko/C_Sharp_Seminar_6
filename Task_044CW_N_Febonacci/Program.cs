// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();
int digit;

Console.Write("Введите число для вывода первых N чисел Фибоначчи: ");

while (true)
{
    if (int.TryParse(Console.ReadLine(), out digit)) break;
    else Console.Write("Ну просил же ЧИСЛО: ");
}

Console.WriteLine($"Первые N чисел Фибоначчи [{string.Join(", ", Febonacci(digit))}].");

int[] Febonacci(int n)
{
    int[] array = new int[n];
    if (n >= 1) array[0] = 0;
    if (n >= 2) array[1] = 1;
    if (n > 2) 
    {
        for (int i = 2; i < n; i++)
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}