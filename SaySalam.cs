using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Interface
{
    class SaySalam : INterface1 
    {
        public string hello(string Name)
        {
            return "Salam Nakhoda " + Name + "!!!";
        }
    }
}
