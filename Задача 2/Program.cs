//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write ("Введите число:  ");
int Number = Convert.ToInt32 (Console.ReadLine());

if (Number >= 100)
{
    while (Number >= 999 ) 
    {
        Number /= 10;
    }
    int Tretye = (Number % 10);
    Console.Write ("Третья цифра:");
    Console.WriteLine (Tretye);
}
else
{
    Console.Write ("Третьей цифры нет!");
}



