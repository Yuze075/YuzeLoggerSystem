using System;

namespace YuzeToolkit.Framework.LoggerSystem
{
    public interface ILogger
    {
        public string[] Tags { get; set; }
        public void Log(string message);
        public void Log(string message, string[] tags);
        public void Log(string message, string savePath);
        public void Log(string message, string[] tags, string savePath);
        public void Warning(string message);
        public void Warning(string message, string[] tags);
        public void Warning(string message, string savePath);
        public void Warning(string message, string[] tags, string savePath);
        public void Error(string message);
        public void Error(string message, string[] tags);
        public void Error(string message, string savePath);
        public void Error(string message, string[] tags, string savePath);
        public void Exception(Exception exception);
        public void Exception(Exception exception, string[] tags);
        public void Exception(Exception exception, string savePath);
        public void Exception(Exception exception, string[] tags, string savePath);
    }
}