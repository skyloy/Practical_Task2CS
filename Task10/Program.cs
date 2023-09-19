//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void Tens(int num=0)
{
    if(num<100 || num >999){
        Console.WriteLine("Error");
    }
    else{
        int double_digit = num / 10;
        int tens = double_digit % 10;
        Console.WriteLine($"result is {tens}");
}
}


Console.WriteLine("Input a number: ");
int result = Convert.ToInt32(Console.ReadLine());
Tens(result);