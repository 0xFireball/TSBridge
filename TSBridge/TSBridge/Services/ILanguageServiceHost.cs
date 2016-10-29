
namespace TSBridge.Services
{
    internal interface ILanguageServiceHost : ILogger, IReferenceResolverHost
    {
        CompilationSettings getCompilationSettings();

        string[] getScriptFileNames();

        int getScriptVersion(string fileName);

        bool getScriptIsOpen(string fileName);

        ByteOrderMark getScriptByteOrderMark(string fileName);

        ILanguageServicesDiagnostics getDiagnosticsObject();

        string getLocalizedDiagnosticMessages();
    }
}