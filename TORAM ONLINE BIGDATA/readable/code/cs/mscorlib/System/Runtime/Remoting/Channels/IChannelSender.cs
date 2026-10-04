// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public interface IChannelSender : IChannel // TypeDefIndex: 10260
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI);
}
