//Intro();

string sentence = "My name is Nizes Lore";
var result = sentence.Length;
Console.WriteLine(result);

var result2 = sentence.Clone();
sentence = "My name is Ayşe";


bool result3 = sentence.EndsWith("e");
bool result4 = sentence.StartsWith("My name");
var result5 = sentence.IndexOf("name");
var result6 = sentence.IndexOf(" ");
var result7 = sentence.LastIndexOf(" ");
var result8 = sentence.Insert(0, "Hello, ");
var result9 = sentence.Substring(3, 4);
var result10 = sentence.ToLower();
var result11 = sentence.ToUpper();
var result12 = sentence.Replace(" ","-");
var result13 = sentence.Remove(2,5);


Console.WriteLine(result13);





Console.ReadLine();

static void Intro()
{
    string city = "Artvin";
    Console.WriteLine(city);
    foreach (var item in city)
    {
        Console.WriteLine(item);
    }

    string city2 = "Ankara";
    //string result = city + city2;  Burada bellekte result adında bir değişken oluşturduk.
    //Bunu bellekte oluşturmadan da aşağıdaki gibi devam edilebilir.

    Console.WriteLine(String.Format("{0} {1}", city, city2));
}