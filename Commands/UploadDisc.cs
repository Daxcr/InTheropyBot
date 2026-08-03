using Discord;
using Discord.Interactions;

namespace Commands;

public class UploadDiscCommand : InteractionModuleBase<SocketInteractionContext>
{
    [SlashCommand("upload-disc", "Upload a custom music disc for review")]
    public async Task Upload(string SongName, IAttachment Upload)
    {
        await DeferAsync();

        string extension = Path.GetExtension(Upload.Filename).ToLowerInvariant();
        if (extension != ".wav" && extension != ".mp3")
        {
            await FollowupAsync("Only `.wav` and `.mp3` are supported.");
            return;
        }
        if (Upload.Size > 1024 * 1024 * 25)
        {
            await FollowupAsync("File size must be under 25MB.");
            return;
        }
    }
}