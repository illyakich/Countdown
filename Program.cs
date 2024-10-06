int Countdown(int number)
{
    while (number != 0)
    {
        Console.WriteLine(number);
        return number - Countdown(number - 1);
    }
     
    return number;
}
Countdown(10);