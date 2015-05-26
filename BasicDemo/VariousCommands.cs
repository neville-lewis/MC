using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManyConsole;

namespace BasicDemo
{
    public class ProcessBusFuncA : ConsoleCommand
    {
        private OptionsForBusiness_A _optionsForBusinessA;
        private BusinessFunc_A _command;

        public ProcessBusFuncA()
        {
            IsCommand("BFA", "Does Processing of whatever I need to do for business function A");

            _optionsForBusinessA = new OptionsForBusiness_A();

            HasRequiredOption("Name|n=", "Name of person by who something was done", n => _optionsForBusinessA.Name = n);
            HasOption<int>("logenabled|l", "Should this be logged?", l => _optionsForBusinessA.LogEnabled = true);
            HasOption<int>("id|i=", "Provide a unique ID for this ", i => _optionsForBusinessA.Id = i);

            _command = new BusinessFunc_A(_optionsForBusinessA);        
        }


        public override int Run(string[] remainingArguments)
        { 

            _command.DoJob();
            return 0;
        }
    }




    public class ProcessBusFuncB : ConsoleCommand
    {


        private OptionsForBusiness_B _optionsForBusinessB;
        private BusinessFunc_B _command;

        public ProcessBusFuncB()
        {
            IsCommand("BFB", "Does Processing of whatever I need to do for business function B");

            _optionsForBusinessB = new OptionsForBusiness_B();

            HasRequiredOption("Name|n=", "place where the something was done", l => _optionsForBusinessB.AccountNumber = "5554554FGHF");
            HasOption("logenabled|l", "include if the something was awesome", _ => _optionsForBusinessB.LogEnabled = true);
            HasOption<int>("id|i=", "number of times something was done", t => _optionsForBusinessB.GUID = "GUID-465TSHSSHFGGB");

            _command = new BusinessFunc_B(_optionsForBusinessB);        
        }


        public override int Run(string[] remainingArguments)
        {
            _command.Run();

            return 0;
        }
    }
}
