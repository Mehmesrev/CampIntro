﻿using System;
using System.Collections.Generic;
using YGYK4_5;

namespace YGYK4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "Bir");
            myDictionary.Add(2, "İki");
            myDictionary.Add(3, "Üç");

            // Şimdi anahtar-değer çiftlerini ekrana yazdırabilirsiniz
            for (int i = 0; i < myDictionary.Length; i++)
            {
                Console.WriteLine("Anahtar: " + myDictionary.Keys[i] + ", Değer: " + myDictionary.Values[i]);
            }
        }
    }
}
