// Assembly: mscorlib.dll
// Namespace: 
private class CrossContextChannel.ContextRestoreSink : IMessageSink // TypeDefIndex: 10238
{
	// Fields
	private IMessageSink _next; // 0x10
	private Context _context; // 0x18
	private IMessage _call; // 0x20

	// Methods

	// RVA: 0x2EE70C8 Offset: 0x2EE30C8 VA: 0x2EE70C8
	public void .ctor(IMessageSink next, Context context, IMessage call) { }

	// RVA: 0x2EE7130 Offset: 0x2EE3130 VA: 0x2EE7130 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x2EE73E4 Offset: 0x2EE33E4 VA: 0x2EE73E4 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}
