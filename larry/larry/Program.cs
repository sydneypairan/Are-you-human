using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace larry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Is lary the best cat in the world?");

            Console.Write("You said " + Console.ReadLine());

            Console.ReadLine(); //ReadLine prevents the console from closing until it gets a response
            Console.Write("you're wrong you must be a robot");
            Console.ReadLine();
        }
    }
}
    
