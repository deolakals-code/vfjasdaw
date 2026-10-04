// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
internal class ServerObjectReplySink : IMessageSink // TypeDefIndex: 10325
{
	// Fields
	private IMessageSink _replySink; // 0x10
	private ServerIdentity _identity; // 0x18

	// Methods

	// RVA: 0x2EF9D40 Offset: 0x2EF5D40 VA: 0x2EF9D40
	public void .ctor(ServerIdentity identity, IMessageSink replySink) { }

	// RVA: 0x2EF9D84 Offset: 0x2EF5D84 VA: 0x2EF9D84 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x2EF9E4C Offset: 0x2EF5E4C VA: 0x2EF9E4C Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}
