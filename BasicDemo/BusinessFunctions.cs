using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
    public class BusinessFunc_A
    {
        private OptionsForBusiness_A _options;

        public BusinessFunc_A(OptionsForBusiness_A options)
        {
            _options = options;
        }


        public void DoJob()
        {

            Console.WriteLine("Business func A done with option NAME:" + _options.Name);

        }
            
    }

    public class BusinessFunc_B
    {
        private OptionsForBusiness_B _options;

        public BusinessFunc_B(OptionsForBusiness_B options)
        {
            _options = options;
        }


        public void Run()
        {

            Console.WriteLine("Business func B was run with option ACCOUNTNUMER:" + _options.AccountNumber);
        }

    }
}
