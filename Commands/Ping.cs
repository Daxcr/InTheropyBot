using Discord;
using Discord.Interactions;

namespace Commands;

public class KillCommand : InteractionModuleBase<SocketInteractionContext>
{
    [SlashCommand("ping", "pong")]
    public async Task Ping()
    {
        await RespondAsync("Pong!");
    }
}