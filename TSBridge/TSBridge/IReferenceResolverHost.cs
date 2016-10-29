namespace TSBridge
{
    internal interface IReferenceResolverHost
    {
        IScriptSnapshot getScriptSnapshot(string fileName);

        string resolveRelativePath(string path, string directory);

        bool fileExists(string path);

        bool directoryExists(string path);

        string getParentDirectory(string path);
    }
}