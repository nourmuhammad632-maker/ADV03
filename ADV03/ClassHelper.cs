using System;
using System.Collections.Generic;
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
    }
}
