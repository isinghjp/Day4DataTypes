using System;
namespace Day4DataTypes
{
    internal class strref
    {
        static void Main(string[] args)
        {
            //int = null;
            //string str = "null";
            //str = "Abcd";
            // nullable int a = 10;
            //bool ? a = true;

            Nullable<int> a = 10;
            if (a.HasValue)
            {
                Console.WriteLine("{0}", a.Value);
            }
            else
            {
                Console.WriteLine("Value not abailable");
            }
            
        }
    }
}
