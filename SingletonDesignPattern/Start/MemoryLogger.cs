namespace SingletonDesignPattern.Start;

public class MemoryLogger
{
    private int _infoCount;
    private int _warningCount;
    private int _errorCount;

    private readonly List<LogMessage> _logs = new();

    public IReadOnlyCollection<LogMessage> Logs => _logs;
     
    private void Log (string message, LogType logType)
    {
        _logs.Add(new LogMessage()
        {
            Message = message,
            LogType = logType,
            CreatedAt = DateTime.Now
        });
    }

    public void LogInfo(string message)
    {
        ++_infoCount;
        Log(message, LogType.Info);
    }

    public void LogError(string message)
    {
        ++_errorCount;
        Log(message, LogType.Error);
    }

    public void LogWarning(string message)
    {
        ++_warningCount;
        Log(message, LogType.Warning);
    }

    public void ShowLog()
    {
        _logs.ForEach(x =>
        {
            Console.WriteLine(x.ToString());
        });

        Console.WriteLine("------------------------------------------------------------------------------------");
        Console.WriteLine($"Info ({_infoCount})  ,  Warning ({_warningCount})  ,  Error ({_errorCount})");
    }
}