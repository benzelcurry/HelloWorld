using HelloWorld;

NameClass nameClass = new NameClass();
AgeClass ageClass = new AgeClass();

Console.WriteLine($"You are {ageClass.CalculateAge(0)} years old");

while (string.IsNullOrEmpty(nameClass.Name))
{
    nameClass.GetName();
}

nameClass.GetLastName();

nameClass.ShowName();
