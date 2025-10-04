namespace BasicEmojiLibrary.EmojiHelpers;
internal static class InternalHelpers
{
    public static void Init()
    {
        bb1.EmojiParserHook ??= new EmojiParsingClass();
    }
}