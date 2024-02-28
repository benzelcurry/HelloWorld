using HelloWorld.Business;

AgeService ageService = new();

try
{
    ageService.OnAgeCalculated += AgeService_OnAgeCalculated;
    int currentAge = ageService.CalculateAge(1982);

    Console.WriteLine($"You are {currentAge} years old");
}
catch (Exception ex)
{
    if (ex.Message.Contains("Year can't be 0 or less"))
    {
        Console.WriteLine("Please enter a year that is higher than 0.");
    }
    else if (ex.Message.Contains("You can't be born in the future!"))
    {
        Console.WriteLine("You can't be of the future.");
    }
    else
    {
        Console.WriteLine($"Something went wrong: {ex.Message}");
    }
}

void AgeService_OnAgeCalculated()
{
    Console.WriteLine("Age has been calculated.");
}
