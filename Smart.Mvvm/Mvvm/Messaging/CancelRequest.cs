namespace Smart.Mvvm.Messaging;

using System.ComponentModel;

public sealed class CancelRequest : IEventRequest<CancelEventArgs>
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public event EventHandler<CancelEventArgs>? Requested;

    public bool IsCancel()
    {
        var args = new CancelEventArgs();
        Requested?.Invoke(this, args);
        return args.Cancel;
    }
}
