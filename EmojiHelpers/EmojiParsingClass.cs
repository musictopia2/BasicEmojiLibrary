namespace BasicEmojiLibrary.EmojiHelpers;
public partial class EmojiParsingClass : IEmojiParserHook
{
    string IEmojiParserHook.ReplaceEmojis(string input)
    {
        // Regex to find :emoji_key: in input, case-insensitive
        return ColonRegex().Replace(input, match =>
        {
            var key = match.Groups[1].Value.ToLowerInvariant(); // normalize key
            return mm1.NameToEmoji.TryGetValue(key, out var emoji) ? emoji : match.Value;
        });
    }

    [GeneratedRegex(@":([a-z0-9_]+):", RegexOptions.IgnoreCase, "en-US")]
    private static partial Regex ColonRegex();
}