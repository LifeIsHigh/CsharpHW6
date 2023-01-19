
Console.Write("Введите значение: ");
int X = Convert.ToInt32(Console.ReadLine());
int Y = 0;
int y = 0;
int x = X;
while (X != 0)
{
    Y++;
    X /= 10;
}
//int a = Y - (Y - 3);
if (Y > 2)
{
    while (x != 0)
    {
        y++;
        x /= 10;
        if (y == Y - (Y - (Y - 3)))
        {
            Console.WriteLine($"Третья цифра введённого числа: {x % 10}");

        }
    }
}
else
{
Console.WriteLine($"Третьей цифры нет");
}