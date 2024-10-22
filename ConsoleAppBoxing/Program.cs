// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

namespace ConsoleAppBoxing
{
    class Program
    {

        private static void Main(string[] args)
        {

        int count = 1000000; 
        List<object> obj_list= new List<object>();

        List<int> val_list = new List<int>();
        System.Console.WriteLine("Boxing : {0} ms",
        DoTest(count, () => 
        {
            int value =123;
            obj_list.Add(value);
        }
        ));
        System.Console.WriteLine("no Boxing : {0} ms",
        DoTest(count, () => 
        {
            int value =123;
            val_list.Add(value);
        }
        ));
        }
        static long DoTest(int count,Action action )
        {
            var sw = Stopwatch.StartNew();
            for(int i = 0;i<count; i++)
            action();
            return sw.ElapsedMilliseconds;
        }
    }
}