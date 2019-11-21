using System;
using System.Collections.Generic;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            var a = new List<string>();
            foreach (string name in strings)
                if (!a.Contains(name))
                    a.Add(name);
            
            return a.ToArray();
        }
    }
}
