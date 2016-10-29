
namespace TSBridge
{
    public interface IScriptSnapshot
    {
        string getText(int start, int end);

        int getLength();

        ITextChangeRange getChangeRange(IScriptSnapshot oldSnapshot);

        int[] getLineStartPositions();

        //TextChangeRange
        string getTextChangeRangeSinceVersion(int scriptVersion);
    }
}