using KrNumber4.Models;

namespace KrNumber4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.MethodCalledTenTimes += (sender, args) => Console.WriteLine("Event 'MethodCalledTenTimes' has been handled.");

            for (int i = 0; i < 15; i++)
            {
                myClass.MyMethod();
            }
            Console.ReadKey();
        }
    }
}
