namespace TSBridge
{
    public interface ITextChangeRange
    {
        ITextSpan span { get; }
        int newLength { get; }
    }
}