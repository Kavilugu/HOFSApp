using System;
using System.Collections.Generic;
using System.Text;

namespace HOFSApp
{
    class DictionaryManager<T1, T2>
    {
        private Dictionary<T1, List<T2>> dictionary = new Dictionary<T1, List<T2>>();

        public DictionaryManager()
        {
        }

        public bool Add(T1 key, T2 value)
        {
            List<T2> list = new List<T2>();
            if (dictionary.ContainsKey(key))
            {
                dictionary.TryGetValue(key, out list);
                list.Add(value);
                return true;
            }
            else
            {
                list.Add(value);
                dictionary.Add(key, list);
                return false;
            }
        }
        public bool Change(T1 key, T2 oldValue, T2 newValue)
        {
            List<T2> list = new List<T2>();
            if (dictionary.ContainsKey(key))
            {
                dictionary.TryGetValue(key, out list);
                list.Remove(oldValue);
                list.Add(newValue);

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(T1 key, T2 value)
        {
            List<T2> list = new List<T2>();
            if (dictionary.ContainsKey(key))
            {
                dictionary.TryGetValue(key, out list);
                if (list.Contains(value))
                {
                    list.Remove(value);
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public bool Get(T1 key, out List<T2> result)
        {
            List<T2> list = new List<T2>();
            result = default;

            if (dictionary.TryGetValue(key, out list))
            {
                result = list;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
