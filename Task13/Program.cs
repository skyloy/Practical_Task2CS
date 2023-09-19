// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void Third_Digit(int num = 0)
{
    if(num < 100)
    {
        Console.WriteLine("The number does not have a third digit");
    }
    else
    {
        while (num >= 999)
        {
            num = num / 10;
        }

        int res = num%10;
        Console.WriteLine($"Third digit is {res}");
    }
}

Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Third_Digit(number);