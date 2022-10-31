//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


int Number = new Random().Next (1, 5000000);
Console.Write ("Число:  ");
Console.WriteLine (Number);

if (Number >= 100)
{
    while (Number >= 100 ) Number /= 10;
    {
        int Tretye = (Number % 10);
        Console.Write ("Третья цифра:");
        Console.WriteLine (Tretye);
    }
}
else
{
    Console.Write ("Третьей цифры нет!");
}



