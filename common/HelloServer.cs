using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{

    public class HelloServer : MarshalByRefObject
    {
        public HelloServer(String myString)
        {
            Console.WriteLine("HelloServer activated");
            Console.WriteLine("Parameter passed to the constructor is " + myString);
        }
        public String HelloMethod(String myName)
        {
            Console.WriteLine("HelloMethod : {0}", myName);
            return "Hi there " + myName;
        }

        public String Hello(String myName)
        {
            Console.WriteLine("Hello : {0}", myName);
            return "Hi there " + myName;
        }

        public String HelloWorld()
        {
            Console.WriteLine("Hello World!");
            return "Return  Hello World!";
        }

        public int Sum(int a,int b)
        {
            Console.WriteLine("sum:{0}",a + b);

            return a+b;
        }
    }
}
