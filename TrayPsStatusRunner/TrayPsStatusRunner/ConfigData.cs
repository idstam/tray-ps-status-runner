using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrayPsStatusRunner
{
    public class ConfigData
    {
        public string TriggerType { get; set; }
        public string TriggerCommand { get; set; }
        public int TriggerInterval { get; set; }
        public string ErrorTrigger { get; set; }
        public string WarningTrigger { get; set; }
        public string InfoTrigger { get; set; }

        public Dictionary<string, string> Scripts { get; set; }
    }
}
