using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringtask2
{
    class Program
    {
        static void fullname(string firstname,string lastname)
        {
            string s=string.Concat(firstname," ", lastname);
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            fullname("rohitha", "sarah");
        }
    }
}
