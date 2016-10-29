namespace TSBridge.Services
{
    internal interface ILanguageServiceHost : ILogger, IReferenceResolverHost
    {
        CompilerOptions getCompilationSettings();

        string[] getScriptFileNames();

        string getScriptVersion(string fileName);

        bool getScriptIsOpen(string fileName);

        string getCurrentDirectory();

        string getDefaultLibFileName(CompilerOptions options);

        ByteOrderMark getScriptByteOrderMark(string fileName);

        ILanguageServicesDiagnostics getDiagnosticsObject();

        string getLocalizedDiagnosticMessages();
    }
}