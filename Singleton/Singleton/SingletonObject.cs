using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SingletonObject
    {
        private static SingletonObject instance = null;
        public static SingletonObject Instance
        {
            get
            {
                Console.WriteLine("Llamando a GetInstance de SingletonObject");

                if (instance == null)
                {
                    instance = new SingletonObject();
                }

                return instance;
            }
        }

        private SingletonObject()
        {
            Console.WriteLine("Llamando al constructor de SingletonObject");
        }

        public void DoSomething()
        {
            Console.WriteLine("Llamando a DoSomething de SingletonObject");
        }
    }
}
