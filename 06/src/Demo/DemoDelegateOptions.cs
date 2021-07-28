using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class DemoDelegateOptions
    {
        public Dictionary<string, string> Data { get; private set; }

        public string this[string key] => Data[key];

        public DemoDelegateOptions()
        {
            Data = new Dictionary<string, string>();
        }

        public DemoDelegateOptions(Dictionary<string, string> customData)
        {
            Data = customData ?? new Dictionary<string, string>();
        }

        public void Add(string key, string value)
        {
            if (key is null) 
                throw new ArgumentNullException(nameof(key));

            if (Data.ContainsKey(key))
                throw new InvalidOperationException(
                    $"Key {key} already exists. Try using different one or use {nameof(AddOrReplace)} method.");

            Data.Add(key, value);
        }

        public void AddOrReplace(string key, string value)
        {
            if (key is null)
                throw new ArgumentNullException(nameof(key));

            if (Data.ContainsKey(key))
                Data[key] = value;
            else
                Data.Add(key, value);
        }

        public void Remove(string key)
        {
            if (key is null)
                throw new ArgumentNullException(nameof(key));

            _ = Data.Remove(key);
        }
    }
}
