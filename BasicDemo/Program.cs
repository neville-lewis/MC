using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManyConsole;

namespace BasicDemo
{

    /// <summary>
    /// Sources:    http://dgondotnet.blogspot.dk/2013/08/my-last-console-application-manyconsole.html
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
