/*
Напишите программу, 
// которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.


// ❗ **Теорема о неравенстве треугольника:
// **каждая сторона треугольника меньше суммы двух других сторон.
*/
Console.Clear();
Console.WriteLine("Введите все три стороны через пробел:");
string []text = Console.ReadLine().Split(' ');
int a = int.Parse(text[0]);
int b = int.Parse(text[1]);
int c = int.Parse(text[2]);
void Triangle(int a, int b, int c)
{
    if (a<b+c && b<a+c && c<a+b)
    {
        Console.WriteLine("да");
    }
    else Console.WriteLine("нет");
}
Console.Write ($"{a} {b} {c}");
Console.WriteLine();
Triangle(a, b, c);
