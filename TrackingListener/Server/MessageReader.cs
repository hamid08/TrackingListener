namespace TrackingListener.Server;

public class MessageReader
{
    public MessageReader(string message)
    {
        Message = message;
    }

    private int index = 0;

    public string Message { get; }

    public string Get(int i)
    {
        return GetNext(i, false);
    }

    private string GetNext(int i, bool skipOne)
    {
        string sub = Message.Substring(index, i);

        index = skipOne ? index + i + 1 : index + i;

        return sub;
    }

    public MessageReader Skip(int i)
    {
        // message = message.Substring(i);
        index += i;

        return this;
    }

    public string GetUntil(char c, int? extra = null)
    {
        int newIndex = Message.Substring(index).IndexOf(c);

        if (extra.HasValue)
        {
            newIndex += extra.Value;
        }

        return GetNext(newIndex, true);
    }

    public void Reset()
    {
        index = 0;
    }
}