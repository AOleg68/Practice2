//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.


Console.Write ("Введите цифру дня недели:  ");
int Den = Convert.ToInt32 (Console.ReadLine());

if (Den < 6)
{
   Console.Write ("Нет");
}
else
{
   Console.Write ("Да");
}