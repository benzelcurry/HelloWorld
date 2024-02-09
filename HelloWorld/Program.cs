using HelloWorld;

NameClass nameClass = new NameClass();
AgeClass ageClass = new AgeClass();

try
{
    Console.WriteLine($"You are {ageClass.CalculateAge(0)} years old");
}
catch (Exception ex)
{
    if (ex.Message.Contains("Year can't be 0 or less"))
    {
        Console.WriteLine("Please enter a year that is higher than 0.");
    }
    else if (ex.Message.Contains("You can't be born in the future!"))
    {
        Console.WriteLine("You can't be born in the future.");
    }
    else
    {
        Console.WriteLine($"Something went wrong: {ex.Message}");
    }    
    
}

Console.WriteLine($"You are {ageClass.CalculateAge(0)} years old");

while (string.IsNullOrEmpty(nameClass.Name))
{
    nameClass.GetName();
}

nameClass.GetLastName();

nameClass.ShowName();
