class proram
{
    public static void Main(string[] args)
    {
        Person[] persons = new Person[3];

        // Input information for 3 persons
        for (int i = 0; i < persons.Length; i++)
        {
            Console.WriteLine($"Enter information for Person {i + 1}:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Salary: ");
            string sSalary = Console.ReadLine();

            persons[i] = InputPersonInfo(name, address, sSalary);
        }

        // Display persons
        Console.WriteLine("\n=== Persons Information ===");
        foreach (var person in persons)
        {
            DisplayPersonInfo(person);
            Console.WriteLine();
        }

        // Sort and display sorted persons
        Console.WriteLine("\n=== Persons Information Sorted by Salary ===");
        persons = SortBySalary(persons);
        foreach (var person in persons)
        {
            DisplayPersonInfo(person);
            Console.WriteLine();
        }
    }
}
