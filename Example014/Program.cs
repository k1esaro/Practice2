Console.WriteLine("Введите день недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number<8)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Будний");
    }
}
else
{
    Console.WriteLine("Ошибка");
}