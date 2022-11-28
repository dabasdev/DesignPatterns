namespace SingletonDesignPattern.Start;

public class LogMessage
{
    public string Message { get; set; } = string.Empty;
    public LogType LogType { get; set; } 
    public DateTime CreatedAt { get; set; }

    public override string ToString()
    {
        var timeStamp = CreatedAt.ToString("yyyy-MM-dd hh:mm");
        return $"{LogType.ToString()?.PadLeft(7, ' ')} [{timeStamp}] {Message}";
    }
}