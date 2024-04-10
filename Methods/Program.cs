Add();
Add();
Add();
Add();
var result = Add2(3, 5);
Console.WriteLine(result);

var result1 = Add3(10);
Console.WriteLine(result1);

void Add()
{
    Console.WriteLine("Added!");
}


//Parameterized method
int Add2(int number1, int number2)
{
    var result = number1 + number2;
    return result;
}


//Method with DEFAULT parameters 
//Eğer number2 verilmezse 30 u kullan, default değer en sağa yazılır.       
int Add3(int number1, int number2 = 30)
{
    var result = number1 + number2;
    return result;
}


//Ref keyword--> Değer tiplerin reference tip gibi kullanılmasını sağlar.
int number1 = 20;
int number2 = 100;
var result2 = Add4(ref number1, number2);
Console.WriteLine(result2);
Console.WriteLine(number1);
int Add4(ref int number1, int number2)
{
    number1 = 30;
    return number1 + number2;
}

//Out keyword--> Değer tiplerin reference tip gibi kullanılmasını sağlar.
//Baştan değerin set edilmesine gerek yok,mutlaka method un içerisinde set edilmeli.
int number3;
int number4 = 400;
var result3 = Add5(out number3, number4);
Console.WriteLine(result3);
Console.WriteLine(number3);
int Add5(out int number3, int number4)
{
    number3 = 70;
    return number3 + number4;
}
