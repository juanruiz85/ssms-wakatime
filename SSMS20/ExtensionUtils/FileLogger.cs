using System;
using System.Globalization;
using System.IO;

namespace WakaTime.ExtensionUtils
{
    /// <summary>
    /// Logger que escribe en un archivo de texto plano (wakatime.log).
    /// Se usa junto con el OutputWindow para que el modo Debug deje también
    /// rastro en disco, independientemente de si la ventana de salida está visible.
    /// </summary>
    public class FileLogger : Shared.ExtensionUtils.ILogger
    {
        private readonly string _logFilePath;
        private readonly ILogger _outputLogger;
        private readonly object _fileLock = new object();
        private bool _failed;

        public FileLogger(ILogger outputLogger, string logFilePath)
        {
            _outputLogger = outputLogger;
            _logFilePath = logFilePath;
        }

        public void Debug(string message)
        {
            _outputLogger.Debug(message);
            Write("Debug", message);
        }

        public void Error(string message, Exception ex = null)
        {
            _outputLogger.Error(message, ex);
            Write("Error", ex == null ? message : $"{message}: {ex}");
        }

        public void Warning(string message)
        {
            _outputLogger.Warning(message);
            Write("Warning", message);
        }

        public void Info(string message)
        {
            _outputLogger.Info(message);
            Write("Info", message);
        }

        private void Write(string level, string message)
        {
            // Si el logging a archivo ya falló una vez, no reintentar en cada heartbeat.
            if (_failed || string.IsNullOrEmpty(_logFilePath)) return;

            try
            {
                var dir = Path.GetDirectoryName(_logFilePath);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                var line = string.Format(CultureInfo.InvariantCulture,
                    "[WakaTime {0} {1:yyyy-MM-dd HH:mm:ss}] {2}{3}",
                    level, DateTime.Now, message, Environment.NewLine);

                lock (_fileLock)
                {
                    File.AppendAllText(_logFilePath, line);
                }
            }
            catch
            {
                _failed = true;
            }
        }
    }
}
