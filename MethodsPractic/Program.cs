using System;

class Program
{
    //değer döndürmeyen method
    static void Music()
    {
        Console.WriteLine("Hayatın ritmi, kalbinin atışında gizli; her anı bir melodi, seninle anlam bulur.");
    }
    //Rastgele sayı üretip döndüren method
    public int RandomNumber()
    {
        Random rnd = new Random();
        int number = rnd.Next(1,30);
        int remainder = number % 2;
        return remainder;
    }
    //Çarpma işlemi yapan method
    public int Multiplication(int a, int b)
    {
        int total = a * b;
        return total;
    }
    //isim soy isim methodu - parametre alıp geriye değer döndürmeyen
    static void NameSurname(string name, string surname)
    {
        Console.WriteLine("Hoşgeldiniz " + name + " " + surname);
    }
}