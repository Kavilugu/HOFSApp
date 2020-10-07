using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace HOFSApp
{
    [Serializable]
    public abstract class ListManager<T> : IListManager<T>
    {
        private List<T> m_list;

        public ListManager()
        {
            m_list = new List<T>();
        }
        public int Count => m_list.Count;

        public bool Add(T aType)
        {
            if (m_list == null)
            {
                return false;
            }
            m_list.Add(aType);
            return true;
        }

        public bool BinaryDeSerialize(string filepath)
        {
            try
            {
                using (Stream stream = File.Open(filepath, FileMode.Open))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    m_list = (List<T>)binaryFormatter.Deserialize(stream);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool BinarySerialize(string filepath)
        {
            if (filepath.Length > 0)
            {
                try
                {
                    using (Stream stream = File.Open(filepath, FileMode.Create))
                    {
                        var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        binaryFormatter.Serialize(stream, m_list);
                        return true;
                    }
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public bool ChangeAt(T aType, int index)
        {
            if (m_list == null)
            {
                return false;
            }
            m_list[index] = aType;
            return true;
        }

        public bool CheckIndex(int index)
        {
            return (index >= 0 && index < m_list.Count);
        }

        public void DeleteAll()
        {
            m_list = new List<T>();
        }

        public bool DeleteAt(int index)
        {
            if (m_list == null)
            {
                return false;
            }
            m_list.RemoveAt(index);
            return true;
        }

        public T GetAt(int index)
        {
            return m_list[index];
        }

        public string[] ToStringArray()
        {
            string[] stringArray = new string[m_list.Count];

            for (int i = 0; i < m_list.Count; i++)
            {
                string temp = m_list.Count.ToString();
                stringArray[i] = temp;
            }

            return stringArray;
        }

        public List<string> ToStringList()
        {
            List<string> stringList = new List<string>();

            for (int i = 0; i < m_list.Count; i++)
            {
                string temp = m_list.Count.ToString();
                stringList.Add(temp);
            }

            return stringList;
        }

        public abstract bool XMLSerialize(string filepath);
        
        public List<T> getList()
        {
            List<T> list = new List<T>();
            for (int i = 0; i < Count; i++)
            {
                list.Add(GetAt(i));
            }
            return list;
        }
    }
}