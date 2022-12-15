using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4DataTypes
{
    internal class Collas
    {
        static void Main(string[] args)
        {
            Nullable<int> a = null;
            int b;
            b = a ?? 0; //first not 
            Console.WriteLine("{0}", b);
        }
    }
}
