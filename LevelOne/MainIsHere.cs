using System;

namespace LevelOne
{
    /// <summary>
    /// This is the main file of this program.
    /// </summary>
    public class MainIsHere
    {
        /// <summary>
        /// The program starts here
        /// </summary>
        /// <param name="args">the command line arguments are here</param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP!");
            PrintSomething("Goodbye world");
        }
        /// <summary>
        /// This method prints something!
        /// </summary>
        /// <param name="something"> Something to Print</param>
        private static void PrintSomething(string something)
        {
            Console.WriteLine(something);
        }
    }
}
