using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Discord.Commands;

namespace Rift_S_Availability_Checker.Modules
{
    public class TimerCheck : ModuleBase<SocketCommandContext>
    {
        static System.Timers.Timer timer;
        public void StartTimer()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000 * 60 * 60;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.Start();
        }
        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            IsAvailable();
        }

        public bool IsAvailable()
        {
            return OculusScraper.IsAvailable();
        }

    }
}
