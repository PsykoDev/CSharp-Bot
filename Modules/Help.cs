﻿using Discord;
using Discord.Commands;
using System;
using System.Threading.Tasks;

namespace csharp_discord_bot.Modules
{
    public class Help : ModuleBase<SocketCommandContext>
    {
        [Command("help")]
        public async Task HelpAsync()
        {
            var builder = new EmbedBuilder()
    .WithTitle("~(C# bot help )~")
    .WithColor(new Color(0xFF00FF))
                    .WithDescription(
                    $"** Prefix: ** :exclamation:\n" +
                    $"** Command: ** [Click Here](https://github.com/PsykoDev/CSharp-Bot/blob/main/Doc/Command.md)\n" +
                    $"** Need Help: ** [Click Here](https://github.com/PsykoDev/CSharp-Bot/issues)\n")
    .WithTimestamp(DateTimeOffset.FromUnixTimeMilliseconds(1610151618624));
            var embed = builder.Build();
            await ReplyAsync(
                null,
                embed: embed)
                .ConfigureAwait(false);
        }
    }
}