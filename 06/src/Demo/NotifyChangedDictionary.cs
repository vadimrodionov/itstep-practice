using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class NotifyChangedStringDictionary
    {
        private Dictionary<string, string> _data;

        public event DemoDelegate NotifyDataChanged;

        public NotifyChangedStringDictionary()
        {
            _data = new Dictionary<string, string>();
        }

        public NotifyChangedStringDictionary(Dictionary<string, string> data)
        {
            _data = data ?? new Dictionary<string, string>();
        }

        void OnDataChanged()
        {
            try
            {
                NotifyDataChanged(new DemoDelegateOptions(_data));
            }
            catch (NullReferenceException) { }
        }

        public string this[string key]
        {
            get => _data[key];
            set
            {
                _data[key] = value;
                OnDataChanged();
            }
        }

        public void Add(string key, string value)
        {
            if (key is null)
                throw new ArgumentNullException(nameof(key));

            if (_data.ContainsKey(key))
                throw new InvalidOperationException(
                    $"Key {key} already exists. Try using different one or use {nameof(AddOrReplace)} method.");

            _data.Add(key, value);
            OnDataChanged();
        }

        public void AddOrReplace(string key, string value)
        {
            if (key is null)
                throw new ArgumentNullException(nameof(key));

            if (_data.ContainsKey(key))
                _data[key] = value;
            else
                _data.Add(key, value);

            OnDataChanged();
        }

        public void Remove(string key)
        {
            if (key is null)
                throw new ArgumentNullException(nameof(key));

            if (_data.Remove(key))
                OnDataChanged();
        }
    }
}
