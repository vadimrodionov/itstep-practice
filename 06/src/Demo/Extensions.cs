using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public static class Extensions
    {
        public static void AddRange(
            this NotifyChangedStringDictionary target, 
            ICollection<KeyValuePair<string, string>> values) 
        {
            foreach (var (key, value) in values)
                target.AddOrReplace(key, value);
        }

        public static NotifyChangedStringDictionary Add(
            this NotifyChangedStringDictionary target,
            string key, string value)
        {
            target.Add(key, value);
            return target;
        }
    }
}
