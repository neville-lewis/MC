using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManyConsole;

namespace BasicDemo
{

    /// <summary>
    ///                 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleCommandDispatcher.DispatchCommand(getCommands(), args, Console.Out);

            Console.ReadKey();
        }

        static IEnumerable<ConsoleCommand> getCommands()
        {

            IEnumerable<ConsoleCommand> ret= ConsoleCommandDispatcher.FindCommandsInSameAssemblyAs(typeof (Program));


            return ret;

        }
    }
}
