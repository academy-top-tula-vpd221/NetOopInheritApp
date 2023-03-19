Human human = new("Bob", 75);
Employee employee = new("Joe", 32, "Yandex");
Client client = new("Sam", 29, "Moscow");

Human human1 = new Employee("Leo", 75, "Google");
Human human2 = new Client("Jim", 22, "Orel");
// Employee employee2 = new Client("Peet", 41, "Orel"); // Error!

Print(human); Console.WriteLine();
Print(human1); Console.WriteLine();
Print(human2); Console.WriteLine();

void Print(Human? human)
{
    //Employee employee = null;
    //if (human is Employee)
    //    employee = human as Employee;

    //if(human is Employee employee)
    //    employee?.Print();
    //if (human is Client client)
    //    client?.Print();
    //if(human is Human human1)
    //    human1?.Print();

    human?.Print();
}

class MyClass
{

}
public class Human 
{
    public string? Name { get; set; }
    int age;
    public virtual int Age
    {
        get
        {
            return age;
        }
        set
        {
            if( value > 0 && value < 100 ) age = value;

        }
    }
    public Human(){ }
    public Human(string? name, int age) 
    { 
        this.Name = name;
        this.Age = age;
    }

    public virtual void Print()
    {
        Console.Write($"Name: {Name}, Age: {Age}");
    }
}

public class Employee : Human
{
    public string? Company { get; set; }

    public override int Age
    {
        get
        {
            return base.Age;
        }
        set
        {
            if(value > 0 && value < 60 )
                base.Age = value;
        }
    }

    public Employee(string? name, int age, string company)
        : base(name, age)
    {
        this.Company = company;
    }

    public override sealed void Print()
    {
        base.Print();
        Console.WriteLine($", Company: {Company}");
    }
}

public class Client : Human
{
    public string? Address { get; set; }

    public Client(string? name, int age, string address)
        : base(name, age)
    {
        this.Address = address;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($", Address: {Address}");
    }
}