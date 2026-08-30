using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ADV03
{
    internal class ClassHelper
    {
        public static  void Printlist<T>(string name, List<T> list){
        if(!string.IsNullOrEmpty(name)&& list is not null&&list.Count>0)
            {
                Console.WriteLine($"Name List:{name}");
                Console.WriteLine(string.Join(", ", list));
            }
        }
        public static void PrintSortedDictionary<Tkey, Tvalue>(string name, SortedDictionary<Tkey, Tvalue> dictionary)
        {
            if (!string.IsNullOrEmpty(name) && dictionary is not null & dictionary.Count > 0)
            {
                Console.WriteLine(name);
                foreach (KeyValuePair<Tkey, Tvalue> pair in dictionary)
                {

                    Console.WriteLine(pair);

                }
            }
        }
            public static void PrintDictionary<Tkey, Tvalue>(string name, Dictionary<Tkey, Tvalue> dictionary)
        {
            if (!string.IsNullOrEmpty(name) && dictionary is not null & dictionary.Count > 0)
            {
                Console.WriteLine(name);
                Console.WriteLine(string.Join(", ", dictionary.Keys));
                Console.WriteLine(string.Join(", ", dictionary.Values));

            }
        }
    }
}
