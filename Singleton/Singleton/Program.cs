using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonObject singletonObject = SingletonObject.Instance;
            singletonObject.DoSomething();
            SingletonObject.Instance.DoSomething();

            var s = SingletonObject.Instance;
            s.DoSomething();
        }
    }
}
