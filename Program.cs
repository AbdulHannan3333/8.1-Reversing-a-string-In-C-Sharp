using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_Reversing_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World!";
            char[] charArray = input.ToCharArray();
            Console.WriteLine(charArray.Length);
            Array.Reverse(charArray);
            string reseverd = new string(charArray);
            Console.WriteLine($"Resevered String: {reseverd}");    
        }
    }
}
