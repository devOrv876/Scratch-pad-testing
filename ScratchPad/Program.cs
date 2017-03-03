using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad

{
    delegate void MyDelegate();
    class Program
    {
        static void Main()
        {
            MyDelegate del = new MyDelegate(foo);
            del();
            Console.ReadKey();
        }
        static void foo()
        {
            Console.WriteLine("Foo()");
            
        }

    }
}
