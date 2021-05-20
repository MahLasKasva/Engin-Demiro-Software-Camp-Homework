using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryDemo
{
    public class MyDictionary<Tkey, Tvalue>
    {
        private Tkey[] _key;
        private Tvalue[] _value;
        private Tkey[] _tempKey;
        private Tvalue[] _tempValue;


        public MyDictionary()
        {
            _key = new Tkey[0];
            _value = new Tvalue[0];
        }

        public void Add(Tkey key, Tvalue value)
        {
            _tempKey = _key;
            _tempValue = _value;

            _key = new Tkey[_key.Length + 1];
            _value = new Tvalue[_value.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
            }

            for (int i = 0; i < _tempValue.Length; i++)
            {
                _value[i] = _tempValue[i];
            }

            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;

            Console.WriteLine("Added!!!!!!!! ");

        }

    }
}
