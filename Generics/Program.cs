using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler1 = new List<string>();
            sehirler1.Add("İstanbul");
            sehirler1.Add("İstanbul");
            sehirler1.Add("İstanbul");
            Console.WriteLine(sehirler1.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            Console.WriteLine(sehirler2.Count);
        }
    }
    class MyList<T> //GENERİC CLASS
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }  

        public void Add(T item)
        {
            _array = new T[_array.Length + 1];
            _tempArray = _array;
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }   

        public int Count
        {
            get { return _array.Length; }
        }
    }
}