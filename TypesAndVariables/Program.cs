//Console.WriteLine("Hello, TypesAndValues!");
var number13 = 2;
number13 = 'A';
//number13 = "A";
Console.WriteLine("Number13 is :{0}", number13);

double number11 = 10.4;                // Bellekte 64 bit lik veri tutar. Ondalık sayılar , den sonra 15 16 character tutabilir
Console.WriteLine("Number11 is :{0}",number11);

decimal number12 =10.4M;              // , den sonra 28 29 character tutabilir.En sağa m / M yazılmalı
Console.WriteLine("Number12 is : {0}", number12);

char character = 'A';                  //Tek tırnak kullanılır
Console.WriteLine("Character is: {0}",character);

char character1 = 'B';
Console.WriteLine("Character1 is : {0}", (int)character1);

bool condition = true;
bool condition1 = false;

byte number9 = 0;                     //Bellekte byte, 8 bit yani 1 byte yer kaplar. Tamsayı
byte number10 = 255;
Console.WriteLine("Number9 and Number10 are {0},{1}", number9,number10);

short number7 = -32768;               // short 16 bit lik yer tutuyor.Tamsayı
short number8 = 32767;
Console.WriteLine("Number7 and Number8 are {0} and {1}", number7, number8);


int number1 = 10;                      //En fazla 10 basamaklı sayı yazılır. int, 32 bit lik yer kaplıyor.Tamsayı
int number2 = -2147483648;
int number3 = 2147483647;
Console.WriteLine("Number1, Number2 & Number3 are {0},{1} & {2}",number1,number2, number3);

long number4 = 2147483648;
long number5 = -9223372036854775808;
long number6 = 9223372036854775807;     // long, 64 bit lik yer kaplıyor.Tamsayı
Console.WriteLine("Number4,5 and 6 are {0},{1} and {2}", number4, number5, number6);


Console.WriteLine((int)Days.Friday);
enum Days
{
    Monday=10, Tuesday=20, Wednesday=30, Thursday, Friday, Saturday,Sunday
}



