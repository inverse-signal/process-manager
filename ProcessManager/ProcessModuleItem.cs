using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManager
{
    // ProcessModuleItem Class for the process selection.
    public class ProcessModuleItem
    {
        public string ProcessInfo;
        public ProcessModule processmodvalue;
        public override string ToString()
        {
            return this.ProcessInfo;
        }
        public ProcessModuleItem(string procinfo, ProcessModule processmod)
        {
            this.ProcessInfo = procinfo;
            this.processmodvalue = processmod;
        }
    }

}
