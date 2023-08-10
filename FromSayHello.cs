using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Interface
{
    internal class FromSayHello:SayHello
    {
        public int Sum(int a ,  int b)
        {
            return a + b;
        }
    }
}
