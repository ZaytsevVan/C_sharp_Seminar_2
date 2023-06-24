// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Укажите день недели");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day < 8)
    if (day > 0 && day <6)
    {
        Console.WriteLine("нет, это будний день");
    }
    else 
    {
        Console.WriteLine("да, это выходной день");
    }
else
{
Console.WriteLine("Такого дня недели не существует");
}