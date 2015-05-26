using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
    /// <summary>
    /// These are additional parameters or configurations that can be sent into the Console
    /// </summary>
    public class OptionsForBusiness_A
    {

        public string Name { get; set; }
        public int Id { get; set; }
        public bool LogEnabled { get; set; }

    }


    public class OptionsForBusiness_B
    {

        public string AccountNumber { get; set; }
        public string GUID { get; set; }
        public bool LogEnabled { get; set; }

    }
}
