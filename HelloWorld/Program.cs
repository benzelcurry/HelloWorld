using HelloWorld;
using System.Diagnostics;

//NameClass nameClass = new NameClass();
AgeClass ageClass = new AgeClass();

TextWriterTraceListener fileListener = new TextWriterTraceListener("log.txt");
Trace.Listeners.Add(fileListener);
Trace.Listeners.Add(new ConsoleTraceListener());

Trace.WriteLine("Application started");

try
{
    Trace.WriteLine("Trying to calculate the ages.");

    Trace.WriteLine("Calculating year 1996");
    int currentAge = ageClass.CalculateAge(1996);

    Trace.WriteLine("Calculating year 1899");
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

fileListener.Close();


//while (string.IsNullOrEmpty(nameClass.Name))
//{
//    nameClass.GetName();
//}

//nameClass.GetLastName();

//nameClass.ShowName();
