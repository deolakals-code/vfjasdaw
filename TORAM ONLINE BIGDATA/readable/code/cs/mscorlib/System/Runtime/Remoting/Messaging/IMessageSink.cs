// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public interface IMessageSink // TypeDefIndex: 10306
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessage SyncProcessMessage(IMessage msg);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink);
}
