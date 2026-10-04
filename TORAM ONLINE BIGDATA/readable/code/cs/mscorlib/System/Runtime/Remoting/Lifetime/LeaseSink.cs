// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Lifetime
internal class LeaseSink : IMessageSink // TypeDefIndex: 10231
{
	// Fields
	private IMessageSink _nextSink; // 0x10

	// Methods

	// RVA: 0x2EE3E4C Offset: 0x2EDFE4C VA: 0x2EE3E4C
	public void .ctor(IMessageSink nextSink) { }

	// RVA: 0x2EE3E7C Offset: 0x2EDFE7C VA: 0x2EE3E7C Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x2EE41B8 Offset: 0x2EE01B8 VA: 0x2EE41B8 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x2EE3F2C Offset: 0x2EDFF2C VA: 0x2EE3F2C
	private void RenewLease(IMessage msg) { }
}
