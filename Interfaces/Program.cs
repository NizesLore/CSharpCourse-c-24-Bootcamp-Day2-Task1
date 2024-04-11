using System.Threading.Channels;

//InterfacesIntro();


IPerson person1=new Worker();

Console.ReadLine();

static void InterfacesIntro()
{
    PersonManager personManager = new PersonManager();
    Customer customer = new Customer
    {
        Id = 1,
        FirstName = "NİZES",
        LastName = "LORE",
        Address = "Ankara"
    };


    Student student = new Student
    {
        Id = 1,
        FirstName = "Ayşe",
        LastName = "Deniz",
        Departmant = "Computer Sciences"

    };


    personManager.Add(customer);
    personManager.Add(student);
}

interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }

}
class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Address { get; set; }
}


class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Departmant { get; set; }
}


class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Departmant { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}

