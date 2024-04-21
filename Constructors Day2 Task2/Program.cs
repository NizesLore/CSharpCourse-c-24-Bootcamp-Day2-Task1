//Customer customer1 = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };
// {}icindekiler parametre değildir.{ den önce () yazılabilir de yazılmayabilir de.

Customer customer3 = new Customer();//Bu yazım şekli yukarıdaki ile aynıdır.
customer3.Id = 3;
customer3.FirstName = "Lale";
customer3.LastName = "Zambak";
customer3.City = "Bolu";


//Customer customer2 = new Customer(2, "Nizes", "Lore", "Artvin");
// Burada Parametreli Constructor çalışıyor.() icindekiler parametre

class Customer()
{
    //default constructor--> constructor without parameter
    //public Customer()
    //{
            
    //}

    //constructor with parameter
    //public Customer(int id, string firstName, string lastName, string city)
    //{
    //    Id = id;                 // Soldaki Id class ın prop u, sağdaki id () icindeki parametre.                     
    //    FirstName = firstName;   // Id gelen id dir.FirstName gelen firstName dir.
    //    LastName = lastName;     // Buyuk harf olanlar class prop ları, METHOD parametreleri camelCase yazılır.
    //    City = city;             // Böyle buraya bunları yazarak CONSTRUCTOR da değerlerimizi set etmiş olduk.
    //}

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}