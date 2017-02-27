using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TSBridge.Services
{
    public class LanguageServiceHost : ILanguageServiceHost
    {
        private CompilerOptions _options = new CompilerOptions();
        private Dictionary<string, ScriptInfo> _scripts = new Dictionary<string, ScriptInfo>();
        private ILogger _logger;

        public LanguageServiceHost(ILogger logger)
        {
            _logger = logger;
        }

        public LanguageServiceHost(CompilerOptions settings, ILogger logger)
            : this(logger)
        {
            _options = settings;
        }

        public void RemoveFile(string filename)
        {
            _scripts.Remove(filename);
        }

        public void OpenFile(string filename, string content)
        {
            _scripts.Add(filename, new ScriptInfo()
            {
                ByteOrderMark = ByteOrderMark.None,
                Content = content,
                Filename = filename,
                IsOpen = true,
                Version = 1
            });
        }

        #region ILanguageServiceHost

        public CompilerOptions getCompilationSettings()
        {
            return _options;
        }

        public string getCurrentDirectory() => Directory.GetCurrentDirectory();

        public string[] getScriptFileNames()
        {
            return _scripts.Keys.ToArray();
        }

        public string getScriptVersion(string fileName)
        {
            if (!_options.noLib && fileName == getDefaultLibFileName(_options))
            {
                return "0";
            }
            ScriptInfo info;
            if (_scripts.TryGetValue(fileName, out info))
            {
                return info.Version.ToString();
            }
            throw new ArgumentException();
        }

        public bool getScriptIsOpen(string fileName)
        {
            ScriptInfo info;
            if (_scripts.TryGetValue(fileName, out info))
            {
                return info.IsOpen;
            }
            throw new ArgumentException();
        }

        public ByteOrderMark getScriptByteOrderMark(string fileName)
        {
            ScriptInfo info;
            if (_scripts.TryGetValue(fileName, out info))
            {
                return info.ByteOrderMark;
            }
            throw new ArgumentException();
        }

        public ILanguageServicesDiagnostics getDiagnosticsObject()
        {
            throw new NotImplementedException();
        }

        public string getLocalizedDiagnosticMessages()
        {
            return null;
        }

        #endregion ILanguageServiceHost

        #region IReferenceResolverHost

        public IScriptSnapshot getScriptSnapshot(string fileName)
        {
            if (!_options.noLib && fileName == getDefaultLibFileName(_options))
            {
                return new StringScriptSnapshot(_lib_d_ts_content);
            }
            ScriptInfo info;
            if (_scripts.TryGetValue(fileName, out info))
            {
                return new StringScriptSnapshot(info.Content);
            }
            throw new ArgumentException();
        }

        public string resolveRelativePath(string path, string directory)
        {
            throw new NotImplementedException();
        }

        public bool fileExists(string path)
        {
            return File.Exists(path);
        }

        public bool directoryExists(string path)
        {
            return Directory.Exists(path);
        }

        public string getParentDirectory(string path)
        {
            return Directory.GetParent(path).FullName;
        }

        #endregion IReferenceResolverHost

        #region ILogger

        public bool information()
        {
            return _logger.information();
        }

        public bool debug()
        {
            return _logger.debug();
        }

        public bool warning()
        {
            return _logger.warning();
        }

        public bool error()
        {
            return _logger.error();
        }

        public bool fatal()
        {
            return _logger.fatal();
        }

        public void log(string s)
        {
            _logger.log(s);
        }

        public string getDefaultLibFileName(CompilerOptions options) => "lib.d.ts";

        #endregion ILogger

        private class ScriptInfo
        {
            public string Filename;
            public int Version;
            public string Content;
            public ByteOrderMark ByteOrderMark;
            public bool IsOpen;
        }

        #region .NET Helpers

        private string _lib_d_ts_content = string.Empty;

        public void RegisterStdLib(string content)
        {
            _lib_d_ts_content = content;
        }

        #endregion .NET Helpers
    }
}