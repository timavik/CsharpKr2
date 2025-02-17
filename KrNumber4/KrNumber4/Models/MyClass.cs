using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrNumber4.Models
{
    public class MyClass
    {
        private int callCount = 0;

        public event EventHandler MethodCalledTenTimes;

        public void MyMethod()
        {
            callCount++;
            Console.WriteLine($"MyMethod called {callCount} times.");

            if (callCount == 10)
            {
                OnMethodCalledTenTimes();
            }
        }

        protected virtual void OnMethodCalledTenTimes()
        {
            MethodCalledTenTimes?.Invoke(this, EventArgs.Empty);
            Console.WriteLine("Event 'MethodCalledTenTimes' has been raised.");
        }
    }
}
