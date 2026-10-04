// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
internal class ServerObjectTerminatorSink : IMessageSink // TypeDefIndex: 10324
{
	// Fields
	private IMessageSink _nextSink; // 0x10

	// Methods

	// RVA: 0x2EF99D4 Offset: 0x2EF59D4 VA: 0x2EF99D4
	public void .ctor(IMessageSink nextSink) { }

	// RVA: 0x2EF9A04 Offset: 0x2EF5A04 VA: 0x2EF9A04 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x2EF9B78 Offset: 0x2EF5B78 VA: 0x2EF9B78 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}
