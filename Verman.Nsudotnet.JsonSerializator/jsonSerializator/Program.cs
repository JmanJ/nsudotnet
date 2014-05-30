using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonSerializator
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new TestObject();
            var serializator = new Serializator(obj);
            serializator.Serialize();
            Console.Write(serializator.GetResult());
            Console.ReadKey();
        }
    }
}
