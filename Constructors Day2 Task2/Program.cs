Customer customer1 = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };

Customer customer3 = new Customer();
customer3.Id = 3;
customer3.FirstName = "Lale";
customer3.LastName = "Zambak";
customer3.City = "Bolu";


Customer customer2 = new Customer(2, "Nizes", "Lore", "Artvin");

class Customer()
{
    //default constructor

    public Customer(int id, string firstName, string lastName, string city)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}