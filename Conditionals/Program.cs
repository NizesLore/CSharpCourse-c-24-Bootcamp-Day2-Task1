var number = 20;
if (number == 10)
{
    Console.WriteLine("Number is 10");
}
else if (number == 20)
{
    Console.WriteLine("Number is 20");
}
else
{
    Console.WriteLine("Number is not 10 or 20");
}

//Single line if
var number1 = 11; //Eğer sayı 12 ise   ? TRUE          : FALSE
Console.WriteLine(number1 == 12 ? "Number1 is 12" : "Number1 is not 12");


//Switch

switch (number)
{
    case 10:
        Console.WriteLine("Number is 10");
        break;

    case 20:
        Console.WriteLine("Number is 20");
        break;

    default:
        Console.WriteLine("Number is not 10 or 20");
        break;
}

//Condition boundries --> Koşul sınırları
if (number >= 0 && number <= 100)
{
    Console.WriteLine("Number is between 0-100");
}
else if (number > 100 && number <= 200)
{
    Console.WriteLine("Number is between 101-200");
}
else if (number < 0 || number > 200)
{
    Console.WriteLine("Number is less than 0 or greater than 200");
}


//Nested if
if (number < 100)
{
    if (number >= 90 && number < 95)
    {
        Console.WriteLine("Number is not between 90-95");
    }
    else
    {
        Console.WriteLine("Number is less than 90");
    }
    
}




