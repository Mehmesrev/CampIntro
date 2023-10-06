using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGYK4_5
{
    class MyDictionary<Key, Value>
    {
        Key[] keys;
        Value[] values;

        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }
        
        public void Add(Key key, Value value)
        {
            //GEÇİCİ KEY-VALUE LİSTELERİ
            Key[] tempKeys = keys;
            Value[] tempValues = values;

            //LİSTE ELEMAN MIKTARI
            keys = new Key[keys.Length + 1];
            values = new Value[values.Length + 1];
            
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            //LİSTE BOYUTU
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;


        }
    }
}
