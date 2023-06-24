// // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 

 Console.WriteLine("Укажите любое трехзначное число");
 int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
    {
        number = number / 10 % 10;
        Console.WriteLine("Второе число " + number);
    }
else System.Console.WriteLine("Вы ввели некорректное число");