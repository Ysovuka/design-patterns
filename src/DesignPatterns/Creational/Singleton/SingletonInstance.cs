using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Singleton
{
    public sealed class SingletonInstance
    {
        public SingletonInstance(string instanceName)
        {
            InstanceName = instanceName;
        }

        public string InstanceName { get; private set; }

        private static SingletonInstance _instance;
        public static SingletonInstance Instance(string instanceName = "")
        {
            if (_instance == null)
                _instance = new SingletonInstance(instanceName);

            return _instance;
        }
    }
}
