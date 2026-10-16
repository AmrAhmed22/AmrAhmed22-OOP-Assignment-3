namespace RefactoringLab;
public interface INotificationChannel
{
    string Name { get; }
}

public class EmailChannel : INotificationChannel
{
    public string Name => "email";
}

public class SmsChannel : INotificationChannel
{
    public string Name => "sms";
}

public class WhatsAppChannel : INotificationChannel
{
    public string Name => "WhasApp";
}


public class Notification
{
    private readonly INotificationChannel _channel;
    private readonly bool _isUrgent;
    private readonly DateTime? _sendAt;

    public Notification(INotificationChannel channel, bool isUrgent = false, DateTime? sendAt = null)
    {
        _channel = channel;
        _isUrgent = isUrgent;
        _sendAt = sendAt;
    }


    public void Send(string to, string message)
    {
        var urgencyPrefix = _isUrgent ? "[URGENT] " : "";
        var scheduleModifier = _sendAt.HasValue ? $" scheduled {_sendAt.Value:g}" : "";

        Console.WriteLine($"[{_channel.Name}{scheduleModifier}] {to}: {urgencyPrefix}{message}");
    }

}