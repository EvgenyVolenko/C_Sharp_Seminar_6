// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();
int digit;

Console.Write("Введите число в десятичной системе для перевода в двоичную: ");

while (true)
{
    if (int.TryParse(Console.ReadLine(), out digit)) break;
    else Console.Write("Ну просил же ЧИСЛО: ");
}

string s = TenToTwo(digit);

Console.WriteLine($"Введенное число в двоичной форме = {s}");

string TenToTwo (int n)
{
    string dvoich = string.Empty;
    while (n > 0)
    {
        dvoich = dvoich + Convert.ToString(n % 2);
        n = n / 2;
    }
    
    char[] arr = dvoich.ToCharArray();
    Array.Reverse(arr);
    
    return new String(arr);
}