// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Clear();
int a, b, c;
bool pr;

a = vvod("A");
b = vvod("B");
c = vvod("C"); 

pr = Proverka(a, b, c);
if ( pr == true) Console.Write("Треугольник с указанными сторонами существует.");
else Console.Write("Треугольник с указанными сторонами НЕ существует.");

bool Proverka(int first, int second, int fird)
{
    if (first < second + fird && second < first + fird && fird < first + second) 
    {
        return true;
    }
    else return false;
}

int vvod(string storona)
{
    Console.Write($"Введите длинну стороны {storona} треугольника: ");
    int digit;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out digit)) break;
        else Console.Write("Ну просил же ЧИСЛО: ");
    }
    return digit;
}
