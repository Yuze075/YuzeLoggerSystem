namespace YuzeToolkit.Framework.LoggerSystem
{
    public static class LoggerSystem
    {
        public static void Log(string massage)
        {
            UnityEngine.Debug.Log(massage);
        }

        public static void Log(string massage, string[] tags)
        {
            UnityEngine.Debug.Log(massage);
        }

        public static void Warning(string massage)
        {
            UnityEngine.Debug.LogWarning(massage);
        }

        public static void Warning(string massage, string[] tags)
        {
            UnityEngine.Debug.LogWarning(massage);
        }

        public static void Error(string massage)
        {
            UnityEngine.Debug.LogError(massage);
        }

        public static void Error(string massage, string[] tags)
        {
            UnityEngine.Debug.LogError(massage);
        }
    }
}