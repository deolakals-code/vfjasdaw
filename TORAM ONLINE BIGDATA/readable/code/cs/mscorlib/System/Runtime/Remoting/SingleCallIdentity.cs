// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting
internal class SingleCallIdentity : ServerIdentity // TypeDefIndex: 10211
{
	// Methods

	// RVA: 0x2EDC208 Offset: 0x2ED8208 VA: 0x2EDC208
	public void .ctor(string objectUri, Context context, Type objectType) { }

	// RVA: 0x2EDE068 Offset: 0x2EDA068 VA: 0x2EDE068 Slot: 6
	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: 0x2EDE288 Offset: 0x2EDA288 VA: 0x2EDE288 Slot: 7
	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }
}
