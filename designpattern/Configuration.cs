using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace designpattern
{
    public class Configuration
    {
        private static Configuration instance;
        private Dictionary<string, string> setting = new Dictionary<string, string>();

        // private constructor 
        private Configuration() { } // No need to check 'instance' here; the constructor is private.

        public static Configuration Instance //hämta den enda instancen av klassen
        {
            get
            {
                if (instance == null)
                {
                    instance = new Configuration();
                }
                return instance;
            }
        }
        // Method to set a key-value pair 
        public void Set(string key, string value)
        {
            setting[key] = value;
        }
        // Method to get the value for a given key
        public string Get(string key)
        {
            return setting.ContainsKey(key) ? setting[key] : null;
        }
    }
}
