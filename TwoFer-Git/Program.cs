using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoFer_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Name());
            Console.ReadLine();
        }

        public static string Name(string input = null)
        {
            return string.Format("One for {0}, one for me.", input ?? "you");
        } // end of Name method
    }
}
