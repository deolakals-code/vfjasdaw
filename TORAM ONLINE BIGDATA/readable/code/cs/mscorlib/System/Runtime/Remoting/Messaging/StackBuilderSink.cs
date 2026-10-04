// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
internal class StackBuilderSink : IMessageSink // TypeDefIndex: 10326
{
	// Fields
	private MarshalByRefObject _target; // 0x10
	private RealProxy _rp; // 0x18

	// Methods

	// RVA: 0x2EF9E84 Offset: 0x2EF5E84 VA: 0x2EF9E84
	public void .ctor(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x2EF9F4C Offset: 0x2EF5F4C VA: 0x2EF9F4C Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x2EFA3DC Offset: 0x2EF63DC VA: 0x2EFA3DC Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x2EFA510 Offset: 0x2EF6510 VA: 0x2EFA510
	private void ExecuteAsyncMessage(object ob) { }

	// RVA: 0x2EFA018 Offset: 0x2EF6018 VA: 0x2EFA018
	private void CheckParameters(IMessage msg) { }

	[CompilerGenerated]
	// RVA: 0x2EFA6F0 Offset: 0x2EF66F0 VA: 0x2EFA6F0
	private void <AsyncProcessMessage>b__4_0(object data) { }
}
