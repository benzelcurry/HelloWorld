namespace HelloWorld.Business
{
    public class NameService
    {
        public string Name { get; set; }
        private string LastName { get; set; }

        public void GetLastName()
        {
            Console.Write("Your last name: ");

            LastName = Console.ReadLine();

            if (string.IsNullOrEmpty(LastName))
            {
                Console.WriteLine("");
                Console.WriteLine("Last name cannot be empty.");
                Console.WriteLine("");
            }
        }

        public void GetName()
        {
            Console.Write("Type your name and press enter: ");

            Name = Console.ReadLine();

            if (string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("");
                Console.WriteLine("Name cannot be empty!");
                Console.WriteLine("");
            }
        }

        public void ShowName()
        {
            Console.WriteLine($"Welcome {Name} {LastName}");
        }
    }
}
