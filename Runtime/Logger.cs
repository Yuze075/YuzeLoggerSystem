using System;
using System.Collections.Generic;
using System.Linq;

namespace YuzeToolkit.Framework.LoggerSystem
{
    public class Logger : ILogger
    {
        public Logger()
        {
        }

        public Logger(string[] tags)
        {
            if (tags == null) return;
            DoTags = true;
            Tags = tags;
        }

        public Logger(string savePath)
        {
            if (string.IsNullOrEmpty(savePath)) return;
            DoSavePath = true;
            SavePath = savePath;
        }

        public Logger(string[] tags, string savePath)
        {
            if (tags != null)
            {
                DoTags = true;
                Tags = tags;
            }

            if (!string.IsNullOrEmpty(savePath))
            {
                DoSavePath = true;
                SavePath = savePath;
            }
        }

        public string[] Tags { get; set; }
        private string SavePath { get; }
        private bool DoTags { get; }
        private bool DoSavePath { get; }


        public void Log(string message)
        {
            if (DoTags && DoSavePath)
                Log(message, Tags, SavePath);
            else if (DoSavePath)
                Log(message, SavePath);
            else if (DoTags)
                Log(message, Tags);
            else
                LoggerSystem.Log(message);
        }

        public void Log(string message, string[] tags)
        {
            if (DoSavePath)
                Log(message, tags, SavePath);
            else
                LoggerSystem.Log(message, tags);
        }

        public void Log(string message, string savePath)
        {
            if (DoTags)
                Log(message, Tags, savePath);
            else
                LoggerSystem.Log(message, savePath);
        }

        public void Log(string message, string[] tags, string savePath)
        {
            LoggerSystem.Log(message, tags, savePath);
        }

        public void Warning(string message)
        {
            if (DoTags && DoSavePath)
                Warning(message, Tags, SavePath);
            else if (DoSavePath)
                Warning(message, SavePath);
            else if (DoTags)
                Warning(message, Tags);
            else
                LoggerSystem.Warning(message);
        }

        public void Warning(string message, string[] tags)
        {
            if (DoSavePath)
                Warning(message, tags, SavePath);
            else
                LoggerSystem.Warning(message, tags);
        }

        public void Warning(string message, string savePath)
        {
            if (DoTags)
                Warning(message, Tags, savePath);
            else
                LoggerSystem.Warning(message, savePath);
        }

        public void Warning(string message, string[] tags, string savePath)
        {
            LoggerSystem.Warning(message, tags, savePath);
        }

        public void Error(string message)
        {
            if (DoTags && DoSavePath)
                Error(message, Tags, SavePath);
            else if (DoSavePath)
                Error(message, SavePath);
            else if (DoTags)
                Error(message, Tags);
            else
                LoggerSystem.Error(message);
        }

        public void Error(string message, string[] tags)
        {
            if (DoSavePath)
                Error(message, tags, SavePath);
            else
                LoggerSystem.Error(message, tags);
        }

        public void Error(string message, string savePath)
        {
            if (DoTags)
                Error(message, Tags, savePath);
            else
                LoggerSystem.Error(message, savePath);
        }

        public void Error(string message, string[] tags, string savePath)
        {
            LoggerSystem.Error(message, tags, savePath);
        }

        public void Exception(Exception exception)
        {
            if (DoTags && DoSavePath)
                Exception(exception, Tags, SavePath);
            else if (DoSavePath)
                Exception(exception, SavePath);
            else if (DoTags)
                Exception(exception, Tags);
            else
                LoggerSystem.Exception(exception);
        }

        public void Exception(Exception exception, string[] tags)
        {
            if (DoSavePath)
                Exception(exception, tags, SavePath);
            else
                LoggerSystem.Exception(exception, tags);
        }

        public void Exception(Exception exception, string savePath)
        {
            if (DoTags)
                Exception(exception, Tags, savePath);
            else
                LoggerSystem.Exception(exception, savePath);
        }

        public void Exception(Exception exception, string[] tags, string savePath)
        {
            LoggerSystem.Exception(exception, tags, savePath);
        }
    }
}