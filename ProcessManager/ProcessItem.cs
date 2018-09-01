using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManager
{
    public class ProcessItem
    {
        public string ProcessInfo;
        public Process processvalue;
        // Override allows us to overide the string method to return the processinfo string for the list box.
        public override string ToString()
        {
            return this.ProcessInfo;
        }
        public ProcessItem(string procinfo, Process process)
        {
            this.ProcessInfo = procinfo;
            this.processvalue = process;
        }
    }

}
