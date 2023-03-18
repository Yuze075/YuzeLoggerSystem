using UnityEngine;

namespace YuzeToolkit.Framework.LoggerSystem
{
    public static class LoggerSystem
    {
        public static void Log(string message)
        {
            Debug.Log(message);
        }

        public static void Log(string message, string[] tags)
        {
            Debug.Log(message);
        }

        public static void Log(string message, string savePath)
        {
            Debug.Log(message);
        }

        public static void Log(string message, string[] tags, string savePath)
        {
            Debug.Log(message);
        }

        public static void Warning(string message)
        {
            Debug.LogWarning(message);
        }

        public static void Warning(string message, string[] tags)
        {
            Debug.LogWarning(message);
        }

        public static void Warning(string message, string savePath)
        {
            Debug.LogWarning(message);
        }

        public static void Warning(string message, string[] tags, string savePath)
        {
            Debug.LogWarning(message);
        }

        public static void Error(string message)
        {
            Debug.LogError(message);
        }

        public static void Error(string message, string[] tags)
        {
            Debug.LogError(message);
        }

        public static void Error(string message, string savePath)
        {
            Debug.LogError(message);
        }

        public static void Error(string message, string[] tags, string savePath)
        {
            Debug.LogError(message);
        }

        public static void Exception(System.Exception exception)
        {
            Debug.LogException(exception);
        }

        public static void Exception(System.Exception exception, string[] tags)
        {
            Debug.LogException(exception);
        }

        public static void Exception(System.Exception exception, string savePath)
        {
            Debug.LogException(exception);
        }

        public static void Exception(System.Exception exception, string[] tags, string savePath)
        {
            Debug.LogException(exception);
        }
    }
}