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

(double, double) KoordPeresech(int b11, int k11, int b21, int k21)
{
    double xP1 = 0, yP1 = 0;
    xP1 = (b21 - b11) / (k11 - k21);
    yP1 = k11 * xP1 + b11;
    return (xP1, yP1);
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
