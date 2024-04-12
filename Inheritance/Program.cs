Person[] persons = new Person[2] { new Customer(), new Student() };  //Böyle de yazılabilir.

//Böyle de yazılabilir. çünkü INTERFACE tek başına bir anlam ifade etmiyor ama CLASS larda Person bir anlam ifade ediyor. 
Person[] persons1 = new Person[3] { new Customer { FirstName = "Nizes" }, new Student { FirstName = "Tuana" }, new Person { FirstName = "Demir" } };
foreach (var person in persons1)
{
    Console.WriteLine(person.FirstName);
}




class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person
{
    public string City { get; set; }
}

class Student : Person
{
    public string Department { get; set; }
}