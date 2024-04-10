//ForLoop();
//ForLoop1();
//WhileLoop();
//DoWhileLoop();
//ForEachLoop();





//Extract methods
static void ForLoop()
{
    for (int i = 1; i <= 100; i = i + 2)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished!");

}

static void ForLoop1()
{
    for (int i = 100; i >= 0; i = i - 2)
    {
        Console.WriteLine(i);
    }
}

static void WhileLoop()
{
    int number = 100;
    while (number >= 0)
    {
        Console.WriteLine(number);
        number--;
    }
    Console.WriteLine("Now number is {0}", number);
}

static void DoWhileLoop()
{
    int number = 10;
    do
    {
        Console.WriteLine(number);
        number--;
    } while (number >= 0);
}

static void ForEachLoop()
{
    string[] fruits = new string[3] { "Apple", "Banana", "Strawberry" };
    foreach (var fruit in fruits)
    {
        Console.WriteLine(fruit);
    }
}