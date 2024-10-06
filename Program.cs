int Countdown(int number)
{
    Console.WriteLine(number);
    if (number != 0) // only execute if the number doesnot equal to 0
        return number - Countdown(number - 1); // pass the value to the parameter, then execute this method again but subtract 1 from the passed value.
    return number; // the code doesnot work without this idk.
}
Countdown(10);