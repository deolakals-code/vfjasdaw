// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
internal class ClientContextTerminatorSink : IMessageSink // TypeDefIndex: 10294
{
	// Fields
	private Context _context; // 0x10

	// Methods

	// RVA: 0x2EF0D0C Offset: 0x2EECD0C VA: 0x2EF0D0C
	public void .ctor(Context ctx) { }

	// RVA: 0x2EF0D3C Offset: 0x2EECD3C VA: 0x2EF0D3C Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x2EF0F28 Offset: 0x2EECF28 VA: 0x2EF0F28 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}
