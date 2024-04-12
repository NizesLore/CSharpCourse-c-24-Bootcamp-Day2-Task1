Person person1 = new Person();
Person person2 = new Person();

person1.FirstName = "Sezin";
person2 = person1;
person1.FirstName = "Elmas";
Console.WriteLine(person2.FirstName);

Employee employee=new Employee();
employee.FirstName = "Derman";


Customer customer = new Customer();
customer.FirstName = "Nises";
customer.CreditCardNumber = "123456789";

Person person3 = customer;
customer.FirstName = "Ahmet";

Console.WriteLine(((Customer)person3).CreditCardNumber);

PersonManager personManager = new PersonManager();
personManager.Add(customer);



//BASE CLASS: PERSON
class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person
{
    public string CreditCardNumber { get; set; }
}

class Employee : Person
{
    public int EmployeeNumber { get; set; }
}


class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
}