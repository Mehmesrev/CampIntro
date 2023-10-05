using System;
using System.Collections.Generic;

class YGYK4_
{
    static void Main()
    {
        //DİCTİONARY
        Dictionary<string, int> MyDictionary = new Dictionary<string, int>();

        //KEY-VALUE EKLEME
        MyDictionary.Add("Anahtar1", 372);
        MyDictionary.Add("Anahtar2", 929);
        MyDictionary.Add("Anahtar3", 123);

        //DİCTİONARY LİSTELE
        foreach (var kvp in MyDictionary)
        {
            Console.WriteLine("Anahtar: " + kvp.Key + ", Değer: " + kvp.Value);
        }

        //YENİ KEY EKLEME DENEYİ
        string newKey = "Yeni anahtar";
        int newValue = 565;

        //ContainsKey = KEY KONTROL
        if (!MyDictionary.ContainsKey(newKey))
        {
            MyDictionary.Add(newKey, newValue);
            Console.WriteLine("Yeni anahtar eklendi: " + newKey + ", Değer: " + newValue);
        }
        else
        {
            Console.WriteLine("Anahtar zaten var: " + newKey);
        }

        //KEY-VALUE SİLME
        MyDictionary.Remove("Anahtar2");
        Console.WriteLine("Anahtar2 kaldırıldı.");

        //Y-DİCTİONARY LİSTELE
        foreach (var kvp in MyDictionary)
        {
            Console.WriteLine("Anahtar: " + kvp.Key + ", Değer: " + kvp.Value);
        }
    }
}
