// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

int b1 = vvod("b1");
int k1 = vvod("k1");
int b2 = vvod("b2");
int k2 = vvod("k2"); 

(double xP, double yP) = KoordPeresech(b1, k1, b2, k2);
Console.WriteLine($"Координаты точки пересечения X = {xP}, Y = {yP}");

(double, double) KoordPeresech(double b11, double k11, double b21, double k21)
{
    double xP1 = 0, yP1 = 0;
    xP1 = (b21 - b11) / (k11 - k21); // Пришлось принять в метод переменные как double? т.к. некорректно считалась эта формула
    yP1 = k11 * xP1 + b11;           // некорректно считались эти формулы.
    return (xP1, yP1);               // Как лучше? Сразу объявить переменную double или переопределить потом?
}

int vvod(string ratio)
{
    Console.Write($"Введите коэффициент {ratio}: ");
    int digit;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out digit)) break;
        else Console.Write("Ну просил же ЧИСЛО: ");
    }
    return digit;
}
