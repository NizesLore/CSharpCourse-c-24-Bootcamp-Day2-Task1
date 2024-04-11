using Classes;

CustomerManager customerManager=new CustomerManager();
customerManager.Add();
customerManager.Update();


ProductManager productManager=new ProductManager();
productManager.Add();
productManager.Update();


Customer customer = new Customer();
customer.Id = 1;
customer.FirstName = "Nizes";
customer.LastName = "Lore";
customer.City = "Artvin";

Customer customer1 = new Customer
{
    Id=2, FirstName="Ayşe", LastName="Yılmaz", City="Ankara"
};

Console.WriteLine(customer1.FirstName);

Console.ReadLine();
