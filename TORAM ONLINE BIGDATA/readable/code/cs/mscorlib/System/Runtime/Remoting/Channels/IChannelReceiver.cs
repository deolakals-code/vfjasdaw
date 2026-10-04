// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public interface IChannelReceiver : IChannel // TypeDefIndex: 10259
{
	// Properties
	public abstract object ChannelData { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_ChannelData();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void StartListening(object data);
}
