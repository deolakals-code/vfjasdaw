// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
internal class ClientContextReplySink : IMessageSink // TypeDefIndex: 10295
{
	// Fields
	private IMessageSink _replySink; // 0x10
	private Context _context; // 0x18

	// Methods

	// RVA: 0x2EF1178 Offset: 0x2EED178 VA: 0x2EF1178
	public void .ctor(Context ctx, IMessageSink replySink) { }

	// RVA: 0x2EF11BC Offset: 0x2EED1BC VA: 0x2EF11BC Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x2EF12C8 Offset: 0x2EED2C8 VA: 0x2EF12C8 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}
