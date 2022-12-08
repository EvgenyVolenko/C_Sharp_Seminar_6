// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
int digit, count = 0;
string str = string.Empty;

while (str != "stop")
{
    Console.Write("Введите число или 'stop' для останова: ");
    str = Console.ReadLine();
    if (str == "stop") break;
    else if (int.TryParse(str, out digit)) count++;
    else Console.WriteLine("Ну просил же ЧИСЛО! ");
}

Console.WriteLine($"Пользователь ввел число больше '0' {count} раз/раза");