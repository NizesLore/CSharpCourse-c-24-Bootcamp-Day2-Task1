using System.Collections.Generic;

List<string> sehirler = new List<string>();  //Oluştu
sehirler.Add("Ankara");                      //Eleman ekledi
Console.WriteLine(sehirler.Count);           //Eleman sayısı
                           //Count burada bir prop, eğer method olsaydı yanında () olurdu, Count() yazılırdı.
                           //Count bir property ve sadece {get;} yani sadece readonly

MyList<string> sehirler2 = new MyList<string>();
sehirler2.Add("Artvin");
Console.WriteLine(sehirler2.Count);


class MyList<T>       //Generic class
{
    T[] _array;
    T[] _tempArray;   //Geçici array
    public MyList()   //Ctor
    {
        _array = new T[0];   //O elemanlı bir array

    }
    public void Add(T item)
    {
        _tempArray = _array;               //_tempArray, _array in reference ını TUTUYOR
        _array = new T[_array.Length + 1]; // Array lerin eleman sayıını 1 arttırınca NEW lememiz gerekiyor                  

        //Ancak NEW lediğimizde bir önce array gidiyor, yeni array oluşuyor.O nedenle tempArray oluşturuyoruz.
        //O elemanlı bir array old göre bizim onun eleman sayısını her eklememizde 1 arttırmamız gerek.
        for (int i = 0; i < _tempArray.Length; i++) // i< Ne kadar dönecek? _tempArray kadar. _tempArray i aktaracağız
        {                                        // _tempArray şu an burayı tututor,ABC elemanları var ya 3 kere dönecek
            _array[i] = _tempArray[i];           //ABC 012 gibi,_tempArray kadar aktaracak
        }                                        //O yüzden _array in i nci elemanı eşittir _tempArray in i nci elemanı

        _array[_array.Length - 1] = item;        //_array in son elemanı nedir? _array.Length-1

    }
    public int Count
    {
        get { return _array.Length; }
    }
}