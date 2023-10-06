using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGYK4_5
{
    class MyDictionary<Key, Value> //METOT CLASS
    {
        Key[] _keys;
        Value[] _values;

        public MyDictionary()
        {
            _keys = new Key[0];
            _values = new Value[0];
        }

        //EKLEME METODU
        public void Add(Key key, Value value)
        {
            Key[] tempKeys = _keys;
            Value[] tempValues = _values;

            _keys = new Key[_keys.Length + 1];
            _values = new Value[_values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                _keys[i] = tempKeys[i];
                _values[i] = tempValues[i];
            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;
        }

        //
        public int Length
        {
            get { return _keys.Length; }
        }

        public Key[] Keys
        {
            get { return _keys; }
        }

        public Value[] Values
        {
            get { return _values; }
        }
    }
}

