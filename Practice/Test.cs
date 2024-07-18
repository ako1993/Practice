using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public delegate void TestDelegate();
    public class Test
    {
        TestDelegate testDelegate;

        public void writeSomething()
        {
            Console.WriteLine("This is some data");
            testDelegate = () => { Console.WriteLine("This data comes from a delegate"); };
            testDelegate();
        }
    }
}
