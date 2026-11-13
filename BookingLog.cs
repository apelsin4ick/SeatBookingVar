using System.Collections.Concurrent;

namespace Variant09.Services;
//todo 7
public class BookingLog
{
    private readonly ConcurrentQueue<string> _logs = new();

    public void Add(string message)
    {
        string logEntry = $"[{DateTime.Now:HH:mm:ss.fff}] {message}";
        _logs.Enqueue(logEntry);
        Console.WriteLine(logEntry);
    }

    public IEnumerable<string> GetAll() => _logs.ToArray();
}