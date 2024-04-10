//Type 1
string[] students = new string[3];
students[0] = "Nizes";
students[1] = "Ezgi";
students[2] = "Deniz";

foreach (var student in students)
{
    Console.WriteLine(student);
}

//Type 2
string[] students2 = { "Deniz", "Yılmaz", "Erol" };
foreach (var student in students2)
{
    Console.WriteLine(student);
}

//Type 3
string[] students3 = new string[3] { "Ayşe", "Berin", "Işıl" };
//students3[3] = "Nizes";
foreach (var student in students3)
{
    Console.WriteLine(student);
}

//Multidimensional arrays
string[,] regions = new string[7, 3]
{
    {"İstanbul","İzmit","Balıkesir" },
    {"Ankara","Konya","Kırıkkale" },
    {"Antalya","Adana","Mersin" },
    {"Artvin","Trabzon","Samsun" },
    {"İzmir","Muğla","Manisa" },
    {"Erzurum","Iğdır","Van" },
    {"Mardin","Şanlıurfa","Gaziantep" }

};
for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j= 0; j <= regions.GetUpperBound(1) ; j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("***********");
}


