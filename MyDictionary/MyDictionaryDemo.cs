using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    public class MyDictionaryDemo<K,V>
    {
        K[] _key;
        V[] _value;

        public MyDictionaryDemo()
        {
            _key = new K[0];
            _value = new V[0];
        }

        public void Add(K key,V value)
        {
            K[] tempKey = _key;
            V[] tempValue = _value;

            _key = new K[_key.Length + 1];
            _value = new V[_value.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                _key[i] = tempKey[i];
                _value[i] = tempValue[i];
            }

            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }

        public int Count
        {
            get { return _key.Length; }
        }

        public K[] Key
        {
            get { return _key; }
        }
        public V[] Value
        {
            get { return _value; }
        }
    }
}
