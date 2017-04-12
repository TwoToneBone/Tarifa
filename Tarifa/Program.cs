using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            uint x = uint.Parse(Console.ReadLine());
            uint n = uint.Parse(Console.ReadLine());
            uint buffer = 0;
            uint p = 0;
            for (int i = 0; i < n; i++)
            {
                p = uint.Parse(Console.ReadLine());
                buffer += x - p;
            }
            Console.WriteLine(buffer + x);
        }
    }
}
