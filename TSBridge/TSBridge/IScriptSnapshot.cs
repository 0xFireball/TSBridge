namespace TSBridge
{
    public interface IScriptSnapshot
    {
        string getText(int start, int end);

        int getLength();

        int[] getLineStartPositions();

        //TextChangeRange
        string getTextChangeRangeSinceVersion(int scriptVersion);
    }
}