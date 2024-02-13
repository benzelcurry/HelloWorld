using HelloWorld;
using System.Diagnostics;

Debug.WriteLine("Application started");
NameClass nameClass = new NameClass();
AgeClass ageClass = new AgeClass();

try
{
    Debug.WriteLine("Calculating ages");

    Debug.WriteLine("Calculating age 1996");
    int currentAge = ageClass.CalculateAge(1996);

    Debug.WriteLine("Calculating age 1899");
    int currentAge2 = ageClass.CalculateAge(1899);
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
