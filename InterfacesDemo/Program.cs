IWorker[] workers=new IWorker[3] {new Manager(),new Worker(),new Robot()};
foreach (var worker in workers)
{
    worker.Work();
}

IEat[] eats=new IEat[2] {new Manager(), new Worker()};
foreach (var eat in eats)
{
    eat.Eat();
}



Console.ReadLine();

interface IWorker
{
    void Work();
       
}

interface IEat
{
    void Eat();
}

interface ISalary
{
    void GetSalary();
}



class Manager : IWorker, IEat, ISalary
{
    public void Eat()
    {
        Console.WriteLine("Manager is eating!");
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        Console.WriteLine("I am a manager and I am working now");
    }
}

class Worker : IWorker, IEat, ISalary
{
    public void Eat()
    {
        Console.WriteLine("Worker is eating!");
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        Console.WriteLine("I am a worker and I am working now");
    }
}

class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("I am a robot and I am working now");
    }
}
