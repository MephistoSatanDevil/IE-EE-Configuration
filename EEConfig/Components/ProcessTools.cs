using System.Diagnostics;

namespace EEConfig.Components
{
    public class ProcessTools
    {
        public static bool IsProcessRunning(string processName)
        {
            return Process.GetProcessesByName(processName).Length > 0;
        }
    }
}
