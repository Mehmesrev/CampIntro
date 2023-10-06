using System;

using System;

namespace YGYK4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {   //MYDİCTİONARY İSİMLİ DİCTİONARY
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            //KEY-VALUE EKLEME
            myDictionary.Add(1, "Bir");
            myDictionary.Add(2, "İki");
            myDictionary.Add(3, "Üç");

            //LİSTEMELE
            for (int i = 0; i < myDictionary.Length; i++)
            {
                Console.WriteLine("Anahtar: " + myDictionary.Keys[i] + ", Değer: " + myDictionary.Values[i]);
            }
        }
    }
}
