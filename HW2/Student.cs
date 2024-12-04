class Person
{
    private string name;
    private string address;
    private double salary;

    public Person(string name, string address, double salary)
    {
        this.name = name;
        this.address = address;
        this.salary = salary;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public static Person InputPersonInfo(string name, string address, string sSalary)
    {
        double salary;
        while (true)
        {
            if (!double.TryParse(sSalary, out salary))
            {
                Console.WriteLine("Error: Salary must be a number. Please re-enter salary:");
                sSalary = Console.ReadLine();
                continue;
            }

            if (salary < 0)
            {
                Console.WriteLine("Error: Salary must be a positive number. Please re-enter salary:");
                sSalary = Console.ReadLine();
                continue;
            }

            break;
        }

        return new Person(name, address, salary);
    }