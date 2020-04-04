using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;

namespace Rift_S_Availability_Checker.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task Ping()
        {
            await ReplyAsync("Charlie Is Big Gae <3");
        }

        [Command("CheckRiftS")]
        public async Task CheckAvailability()
        {

            await ReplyAsync(OculusScraper.CheckIfAvailable());
        }

        [Command("ExciteCharlie")]
        public async Task TellMeItsOkay()
        {

            await ReplyAsync(Context.Message.Author.Mention + "It's Available");
        }

        [Command("BeginTimer")]
        public async Task BeginTimer()
        {
            TimerCheck timer = new TimerCheck();
            timer.StartTimer();
            if (timer.IsAvailable())
            {
                await ReplyAsync(Context.Message.Author.Mention + "It's Available");
            }
            else
            {
                await BeginTimer();
            }
        }

    }
}
