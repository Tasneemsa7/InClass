
using System;
using System.Collections.Generic;

// Step 1: Apply ISP

public interface INotificationChannel
{
    void Send(string message);
}

public interface IMessageLogger
{
    void Log(string message);
}

// Step 3: Implement the interfaces

public class EmailChannel : INotificationChannel
{
    public void Send(string message)
    {
        Console.WriteLine($"[Email] {message}");
    }
}

public class SmsChannel : INotificationChannel
{
    public void Send(string message)
    {
        Console.WriteLine($"[SMS] {message}");
    }
}

public class FileLogger : IMessageLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[Log] {message}");
    }
}

// Step 2: Apply DIP

public class NotificationService
{
    private readonly INotificationChannel _channel;
    private readonly IMessageLogger _logger;

    public NotificationService(
        INotificationChannel channel,
        IMessageLogger logger)
    {
        _channel = channel;
        _logger = logger;
    }

    public void Send(string message)
    {
        _channel.Send(message);
        _logger.Log(message);
    }
}

// Step 4: Main

public class Program
{
    public static void Main()
    {
        INotificationChannel email = new EmailChannel();
        IMessageLogger logger = new FileLogger();

        NotificationService service =
            new NotificationService(email, logger);

        service.Send("Hello from Session 7!");

        // Bonus Challenge

        List<INotificationChannel> channels =
            new List<INotificationChannel>
            {
                new EmailChannel(),
                new SmsChannel()
            };

        foreach (INotificationChannel channel in channels)
        {
            channel.Send("Hello from Session 7!");
        }
    }
}
