// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting
internal class ClientActivatedIdentity : ServerIdentity // TypeDefIndex: 10209
{
	// Fields
	private MarshalByRefObject _targetThis; // 0x70

	// Methods

	// RVA: 0x2EDC180 Offset: 0x2ED8180 VA: 0x2EDC180
	public void .ctor(string objectUri, Type objectType) { }

	// RVA: 0x2EDD888 Offset: 0x2ED9888 VA: 0x2EDD888
	public MarshalByRefObject GetServerObject() { }

	// RVA: 0x2EDD890 Offset: 0x2ED9890 VA: 0x2EDD890
	public void SetClientProxy(MarshalByRefObject obj) { }

	// RVA: 0x2EDD898 Offset: 0x2ED9898 VA: 0x2EDD898 Slot: 5
	public override void OnLifetimeExpired() { }

	// RVA: 0x2EDD8F4 Offset: 0x2ED98F4 VA: 0x2EDD8F4 Slot: 6
	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: 0x2EDDBA0 Offset: 0x2ED9BA0 VA: 0x2EDDBA0 Slot: 7
	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }
}
