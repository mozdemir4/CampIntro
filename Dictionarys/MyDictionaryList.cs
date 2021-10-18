using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionarys
{
    class MyDictionaryList<TKey, TValue>
    {
        TKey[] _keys;
        TValue[] _values;

        public MyDictionaryList()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }

        public void Add(TKey keys, TValue values)
        {
            TKey[] _tempKeys = _keys;
            TValue[] _tempValues = _values;

            _keys = new TKey[_keys.Length + 1];

            _values = new TValue[_values.Length + 1];

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                _keys[i] = _tempKeys[i];
                _values[i] = _tempValues[i];
            }

            _keys[_keys.Length - 1] = keys;
            _values[_values.Length - 1] = values;
        }

        public int Count {
            get { return _keys.Length; }
        }
    }
}
