using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4DataTypes
{
    public enum Color
    {
        white,
        Black,
        Red,
        Green,
        Blue
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Color c = Color.Red;
            ValidateValue(c);
           
        }
        static void ValidateValue(Color p)
        {
            switch (p)
            {
                case Color.Black:
                    Console.WriteLine("Black");
                    break;
                case Color.Red:
                    Console.WriteLine("red");
                    break;
                case Color.Green:
                    Console.WriteLine("Green");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

        }

       
    }
      
}
