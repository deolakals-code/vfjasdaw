// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting
internal class DisposerReplySink : IMessageSink // TypeDefIndex: 10212
{
	// Fields
	private IMessageSink _next; // 0x10
	private IDisposable _disposable; // 0x18

	// Methods

	// RVA: 0x2EDE440 Offset: 0x2EDA440 VA: 0x2EDE440
	public void .ctor(IMessageSink next, IDisposable disposable) { }

	// RVA: 0x2EDE484 Offset: 0x2EDA484 VA: 0x2EDE484 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x2EDE5A0 Offset: 0x2EDA5A0 VA: 0x2EDE5A0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}
