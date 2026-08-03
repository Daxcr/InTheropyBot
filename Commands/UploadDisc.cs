using Discord;
using Discord.Interactions;

namespace Commands;

public class UploadDiscCommand : InteractionModuleBase<SocketInteractionContext>
{
    [SlashCommand("upload-disc", "Upload a custom music disc for review")]
    public async Task Upload(
        [Summary("songName", "Song Name")]
        string SongName,
        [Summary("upload", "File")]
        IAttachment Upload)
    {
        await RespondAsync("debug");
    }
}