// Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N

int number = Convert.ToInt32(Console.ReadLine());

int Number = 2;

if(number > 1)
{
    while(Number <= number)
    {
        Console.Write(Number + " ");
        Number = Number + 2;
    }
}