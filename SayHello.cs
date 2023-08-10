using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Interface
{
    class SayHello : INterface1
    {
        public string hello(string Name)
        {
            return "Hello " + Name + "!!!";
        }

        public string goodbay(string Name)//این یکی در اینترفیس وجود نداشت
        {
            return "GoodBay" + Name + "!";
        }
    }
}
