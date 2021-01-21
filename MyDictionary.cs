using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    public class MyDictionary<Key, Value>
    {
        private Key[] keys;
        private Value[] vlaues;
        public MyDictionary()
        {
            keys = new Key[0];
            vlaues = new Value[0];
        }
        public void Add(Key Keys, Value values)
        {
            Key[] Tkey = keys;
            Value[] Tvalues = vlaues;
            keys = new Key[keys.Length + 1];
            vlaues = new Value[vlaues.Length + 1];
            for (int i = 0; i < keys.Length-1; i++)
            {
                keys[i] = Tkey[i];
                vlaues[i] = Tvalues[i];
            }
            vlaues[vlaues.Length - 1] = values;
            keys[keys.Length - 1] = Keys;
        }

        public int Count()
        {
            return keys.Length;
        }
    }
}
