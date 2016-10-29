using System;

namespace TSBridge
{
    internal class StringScriptSnapshot : IScriptSnapshot
    {
        private string _text;

        public StringScriptSnapshot(string text)
        {
            _text = text;
        }

        public string getText(int start, int end)
        {
            return _text.Substring(start, end - start);
        }

        public int getLength()
        {
            return _text.Length;
        }

        public int[] getLineStartPositions()
        {
            return TextUtilities.ParseLineStarts(_text);
        }

        public string getTextChangeRangeSinceVersion(int scriptVersion)
        {
            throw new NotImplementedException();
        }

        public ITextChangeRange getChangeRange(IScriptSnapshot oldSnapshot)
        {
            throw new NotImplementedException();
        }
    }
}