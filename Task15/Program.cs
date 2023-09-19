// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void DayOfTheWeek(int day = 0)
{
    if(day < 1 || day > 7)
    {
        Console.WriteLine("Error");
    }
    else if(day == 6 || day == 7)
    {
        Console.WriteLine("It's weekend day");
    }
    else
    {
        Console.WriteLine("It's not weekend day");
    }
}
Console.WriteLine("Enter the day of the week");
int day = Convert.ToInt32(Console.ReadLine());

DayOfTheWeek(day);