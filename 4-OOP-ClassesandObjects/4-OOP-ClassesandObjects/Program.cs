
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly BirthDay { get; set; }

    public Person(string fname, string lname, DateOnly birthday)
    {
        FirstName = fname;
        LastName = lname;
        BirthDay = birthday;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($" {FirstName} {LastName}, Born: {BirthDay}");
    }
}

class Program
{
    static void Main()
    {
        // Creating an object (instance of Person class)
        Person p1 = new Person("Denis", "Wachira", new DateOnly(1990, 1, 1));
        p1.DisplayInfo();
    }
}
