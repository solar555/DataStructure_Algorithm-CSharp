using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5_3
{
    public class Timing
    {
        TimeSpan duration;
        public Timing()
        {
            duration = new TimeSpan(0);
        }

        public void StopTime()
        {
            duration = Process.GetCurrentProcess().TotalProcessorTime;
            Console.WriteLine("StopTime duration:" + duration);
        }

        public void StartTime()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("StartTime duration:" + duration);
        }

        public TimeSpan Result()
        {
            return duration;
        }
    }
}
