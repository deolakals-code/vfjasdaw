// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting
internal class SingletonIdentity : ServerIdentity // TypeDefIndex: 10210
{
	// Methods

	// RVA: 0x2EDC20C Offset: 0x2ED820C VA: 0x2EDC20C
	public void .ctor(string objectUri, Context context, Type objectType) { }

	// RVA: 0x2EDDCA0 Offset: 0x2ED9CA0 VA: 0x2EDDCA0
	public MarshalByRefObject GetServerObject() { }

	// RVA: 0x2EDDE8C Offset: 0x2ED9E8C VA: 0x2EDDE8C Slot: 6
	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: 0x2EDDF74 Offset: 0x2ED9F74 VA: 0x2EDDF74 Slot: 7
	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }
}
