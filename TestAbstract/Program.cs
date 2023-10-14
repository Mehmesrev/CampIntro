using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    abstract class Sekil
    {
        // Soyut bir metot tanımlama
        public abstract double AlanHesapla();

        // Somut bir metot
        public void BilgiGoster()
        {
            Console.WriteLine("Bu bir şekildir.");
        }
    }

    class Daire : Sekil
    {
        private double yaricap;

        public Daire(double yaricap)
        {
            this.yaricap = yaricap;
        }

        public override double AlanHesapla()
        {
            return Math.PI * yaricap * yaricap;
        }
    }

    class Kare : Sekil
    {
        private double kenarUzunlugu;

        public Kare(double kenarUzunlugu)
        {
            this.kenarUzunlugu = kenarUzunlugu;
        }

        public override double AlanHesapla()
        {
            return kenarUzunlugu * kenarUzunlugu;
        }
    }
}