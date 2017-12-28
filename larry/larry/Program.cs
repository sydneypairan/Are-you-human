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
            Console.WriteLine("Is lary the best cat in the world?[True/False]");

            bool response = Convert.ToBoolean(Console.ReadLine());

            string Fact1 = "He is white.";
            string Fact2 = "He is fluffy.";
            string Fact3 = "He enjoys eating";
            string Fact4 = "He is a boy.";
            string Fact5 = "He likes ice cream.";

            if (response == false)
            { //ReadLine prevents the console from closing until it gets a response


                Console.BackgroundColor = ConsoleColor.Blue;

                Console.WriteLine("you're wrong you must be a robot");
                Console.BackgroundColor = ConsoleColor.Black;
            }

            else
            {
                Console.WriteLine("You said " + response);


            }
            Console.WriteLine(" What fact do you want to know about Larry? [1-5]");


            string answer = Console.ReadLine();
            if (answer == "1")

            { Console.WriteLine(Fact1);}

           else if (answer == "2")

            { Console.WriteLine(Fact2);}

           else if (answer=="3")

            { Console.WriteLine(Fact3); }

          else  if (answer=="4")
            { Console.WriteLine(Fact4); }

          else  if (answer == "5")
            { Console.WriteLine(Fact5); }

            else { Console.WriteLine("must be value between 1 and 5"); }

            Console.WriteLine("what other facts would you like to know? 6-10");
            string answer2=Console.ReadLine();

            switch (answer2)
            {
                case "6": Console.WriteLine("fact 6 goes here");
                    break;
                default:
                    Console.WriteLine("please enter number between 6 and 10");
                    break;
            }
                
                Console.ReadLine();
        }
    }
}
