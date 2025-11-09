using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
    public sealed class SingletonSettings
    {
        private static SingletonSettings _instance = null;
        private static readonly object _lock = new object();
        private static Dictionary<string, string> _settings = new Dictionary<string, string>();


        public static SingletonSettings GetInstance()
        {
            if (_instance is null)
            {
                lock (_lock)
                {
                    if (_instance is null)
                    {
                        _instance = new SingletonSettings();
                    }
                }

            }
            return _instance;
        }

        public void SetSetting(string name, string vakue)
        {
            lock (_settings)
            {
                _settings.Add(name, vakue);
            }
        }

        public string GetSetting(string name)
        {
            lock (_settings)
            {
                return _settings[name];
            }

        }

        public void DeleteSetting(string name)
        {
            lock (_settings)
            {
                _settings.Remove(name);
            }
        }
    }
}
