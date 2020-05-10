using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SureSQL
{

    public class Model
    {
        private static Model instance = null;
        private static readonly object padlock = new object();

        public Dictionary<string, List<object>> MutliProperties { get; set; }
        public Dictionary<string, string> SingleProperties { get; set; }

        Model()
        {
            MutliProperties = new Dictionary<string, List<object>>();
            SingleProperties = new Dictionary<string, string>();
        }

        public static Model Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Model();
                    }
                    return instance;
                }
            }
        }

        public void AddMultiProperty(string name, List<object> data)
        {
            MutliProperties.Add(name, data);
        }
        public void AddSingleProperty(string name, string data)
        {
            SingleProperties.Add(name, data);
        }
        public List<object> GetMultiProperty(string name, out List<object> value)
        {
            value = new List<object>();
            this.MutliProperties.TryGetValue(name, out value);

            return value;
        }
        public string GetSingleProperty(string name, out string value)
        {
            value = null;
            this.SingleProperties.TryGetValue(name, out value);

            return value;
        }
        public bool CheckSingleProperty(string name)
        {
            return this.SingleProperties.ContainsKey(name);
        }
        public bool CheckMultiProperty(string name)
        {
            return this.MutliProperties.ContainsKey(name);
        }
        public void RemoveSingleProperty(string name) 
        {
            this.SingleProperties.Remove(name);
        }
        public void RemoveMultiProperty(string name)
        {
            this.MutliProperties.Remove(name);
        }
    }

}
