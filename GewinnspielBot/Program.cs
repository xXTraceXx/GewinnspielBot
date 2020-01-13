using System;
using System.Collections.Generic;
using System.Linq;

namespace GewinnspielBot
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] expectedNumbers = new[] { 1, 2, 3, 4 };

            Console.WriteLine("############################################################");
            Console.WriteLine("GewinnspielBot 3000X");
            Console.WriteLine("############################################################");
            Console.WriteLine();

            if (args.Length == 0)
            {
                Console.WriteLine("What action should i perfom?");
                Console.WriteLine();
                Console.WriteLine("[1] Show Unsolved");
                Console.WriteLine("[2] Show Solved");
                Console.WriteLine("[3] Control Panel");
                Console.WriteLine("[4] Exit");

                var input = Console.ReadKey();
                Console.WriteLine();
                int actionNumber;
                var expectedInput = Int32.TryParse(input.KeyChar.ToString(), out actionNumber);
                var res3 = expectedNumbers.Contains(actionNumber);

                while (!expectedInput || !expectedNumbers.Contains(actionNumber))
                {
                    Console.WriteLine("Not the expected input! Try another one!");
                    input = Console.ReadKey();
                    Console.WriteLine();
                    expectedInput = Int32.TryParse(input.KeyChar.ToString(), out actionNumber);
                }

                
                ControlProgram controlProgram = new ControlProgram(actionNumber);

                controlProgram.LoadAction();
            }
        }
    }
}
