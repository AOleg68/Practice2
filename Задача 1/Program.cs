//Напишите программу, которая принимает 
//на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Number = new Random().Next (100, 999);
Console.Write ("Число:  ");
Console.WriteLine (Number);

int Center = (Number % 100) / 10;

Console.Write ("Вторая цифра числа:");
Console.WriteLine (Center);




