string? readResult;
bool validEntry = false;
bool validNumber = false;
Console.WriteLine("Give a value between 5 and 10:");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        validNumber = int.TryParse(readResult, out int result);
        if (validNumber && result >= 5 && result <= 10)
        {
            Console.WriteLine($"Input: {result}");
            validEntry = true;
        }
        else if (validNumber)
        {
            Console.WriteLine("Invalid input. Please enter a number between 5 and 10.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
} while (validEntry == false);

Console.WriteLine("Your input is valid. Thank you!");